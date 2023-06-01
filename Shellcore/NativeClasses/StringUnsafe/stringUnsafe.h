#pragma once
#pragma warning(disable:4996)
#include <comutil.h>
#include <string.h>

//string_unsafe is the same like string class but is based on malloc and free functions
//So this is an unsafe class
//Usage: 
//  string_unsafe variable;
//  string_unsafe variable(const char*);
//  string_unsafe variable(char*);
//  string_unsafe variable(string_unsafe);
//  string_unsafe variable(wchar_t*);

namespace COM
{

	class string_unsafe
    {
	   void Alloc(const char* array){
           if(!array){
				chararray = (char*)CoTaskMemAlloc(sizeof(char) + 1);
				chararray[0] = '\0';
				return;
		   }
		   chararray = (char*)CoTaskMemAlloc(sizeof(char) * (strlen(array) + 1));
		   strcpy_s(chararray, strlen(array) + 1, array);
	   }

  public:
	    char* chararray;
	   //destructor
	   //Completely destroy the string
       ~string_unsafe()
	   {
		   this->clear();
	   }
	   //constructor
	   string_unsafe(){
	       Alloc(nullptr);
	   }

	   //char* copy constructor
	   string_unsafe(char* array){
	       Alloc(array);
	   }

	   //const char* copy constructor
	   string_unsafe(const char* array){
	       Alloc(array);
	   }

	   //wchar_t* copy constructor
	   string_unsafe(wchar_t* wconstantchar){
		   if(!wconstantchar) {
		      	 Alloc(nullptr);
				 return;
		   }
		   size_t size = wcslen(wconstantchar) + 1;
		   chararray = (char*)CoTaskMemAlloc(size);
		   size_t characters_converted = 0;
		   wcstombs_s(&characters_converted, chararray, size, wconstantchar, size - 1);
	   }

	   //copy constructor
	   string_unsafe(const string_unsafe& obj, bool AllocOnCOM = false){
	       Alloc(obj.chararray);
	   }

	   //Returns the size of the string
	   size_t size(){
	      return strlen(chararray) + 1;
	   }

	   //Returns the length of the string
	   size_t length(){
	      return strlen(chararray);
	   }

	   //erase a char from the selected index
	   void erase(size_t _index){
		    memmove(this->chararray + _index, this->chararray + _index + 1, strlen(this->chararray + _index));
	   }

	   //it frees the string inside
	   void clear(){
		    CoTaskMemFree(chararray);
	   }

	   //reverse the string
	   void reverse(){
	      strrev(this->chararray);
	   }
	   
	   //Returns the letter of the selected string
	   //variable[1] => return the letter from position 1
	   char operator[](int index){
	      return chararray[index];
	   }

	   //This is a copy operator.
	   //e.g string_unsafe obj1 = "hello"; 
	   //    string_unsafe obj2 = obj1;
	   //    printf("%s", obj2.c_str());
	   string_unsafe operator=(const string_unsafe &obj){
		   if(this == &obj) return *this;
		   CoTaskMemFree(this->chararray);
		   this->Alloc(obj.chararray);
	       return *this;
	   }

	   //attribution from BSTR to string_unsafe
	   //Alloc method - malloc
	   string_unsafe operator=(const BSTR& obj){
	       this->clear();
		   char* tmp = _com_util::ConvertBSTRToString(obj); //convert to char* and alloc to string_unsafe
		   this->Alloc(tmp);
		   return *this;
	   }

	   //operator + with string_unsafe and char*
	   friend string_unsafe operator+(string_unsafe str1, const char* str){
	        return str1 + string_unsafe(str);
	   }

	   //operator + with char* and string_unsafe
	   friend string_unsafe operator+(const char* str, string_unsafe str1){
	        return string_unsafe(str) + str1;
	   }

	   //operator + with string_unsafe and string_unsafe
	   friend string_unsafe operator+(const string_unsafe& a, const string_unsafe& b){
		    char* __buffer = (char*) CoTaskMemAlloc(strlen(a.chararray) + strlen(b.chararray) + 1);
			strcpy(__buffer, a.chararray);
			strcat(__buffer, b.chararray);
			__buffer[strlen(a.chararray) + strlen(b.chararray)] = '\0';
		    string_unsafe __tmp{__buffer};
			CoTaskMemFree(__buffer);
			return __tmp;
	   }

	   //removes the first character from a string
	   //e.g: abcd => bcd
	   string_unsafe operator++(){
		    this->erase(0);
			return *this;
	   }

	   //increases the string with 1 position ex abcd -> bcd
	   string_unsafe operator++(int){
		    this->erase(0);
			return *this;
	   }

	   //comparator function with const char*
	   friend bool operator==(string_unsafe str1, const char* str){
	        return !strcmp(str1.chararray, str);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator==(string_unsafe str1, string_unsafe str2){
	        return !strcmp(str1.chararray, str2.chararray);
	   }
	   
	   //comparator function with const char*
	   friend bool operator!=(string_unsafe str1, const char* str){
	        return !(str1 == str);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator!=(string_unsafe str1, string_unsafe str2){
	        return !(str1 == str2);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator<(string_unsafe str1, string_unsafe str2){
	        return strcmp(str1.chararray, str2.chararray) < 0;
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator>(string_unsafe str1, string_unsafe str2){
	        return !(str1 < str2);
	   }

	   //Alloc with COM and converts from string_unsafe to char*
	   char* c_str()
	   {
	      char* tmp = (char*)CoTaskMemAlloc(strlen(chararray) + 1);
		  strcpy_s(tmp, strlen(chararray) + 1, chararray);
	      return tmp;
	   }

	   //Converts from string_unsafe to BSTR / OLECHAR*
	   BSTR b_str(){
		   char* tmp = (char*)malloc(strlen(chararray) + 1);
		   strcpy_s(tmp, strlen(chararray) + 1, chararray);
	       BSTR tmpBSTR = _com_util::ConvertStringToBSTR(tmp);
		   free(tmp);
		   return tmpBSTR;
	   }
};
   

}


class string_unsafe
{
   //Default alloc on heap.
   void defaultAlloc(const char* array){
	   if(!array){
	      chararray = (char*)malloc(sizeof(char) + 1);
	      chararray[0] = '\0';
		  return;
	   }
	   chararray = (char*)malloc(sizeof(char) * (strlen(array) + 1));
	   strcpy_s(chararray, strlen(array) + 1, array);
   }

   void Alloc(const char* array){
	   defaultAlloc(array);
   }

   public:
	    char* chararray;
	   //destructor
	   //Completely destroy the string
       ~string_unsafe()
	   {
		   this->clear();
	   }
	   //constructor
	   string_unsafe(){
	       Alloc(nullptr);
	   }

	   //char* copy constructor
	   string_unsafe(char* array){
	       Alloc(array);
	   }

	   //const char* copy constructor
	   string_unsafe(const char* array){
	       Alloc(array);
	   }

	   //wchar_t* copy constructor
	   string_unsafe(wchar_t* wconstantchar){
		   if(!wconstantchar) {
		      	 Alloc(nullptr);
				 return;
		   }
		   size_t size = wcslen(wconstantchar) + 1;
	       chararray = (char*)malloc(size);
		   size_t characters_converted = 0;
		   wcstombs_s(&characters_converted, chararray, size, wconstantchar, size - 1);
	   }

	   //copy constructor
	   string_unsafe(const string_unsafe& obj){
	       Alloc(obj.chararray);
	   }

	   //Returns the size of the string
	   size_t size(){
	      return strlen(chararray) + 1;
	   }

	   //Returns the length of the string
	   size_t length(){
	      return strlen(chararray);
	   }

	   //erase a char from the selected index
	   void erase(size_t _index){
		    memmove(this->chararray + _index, this->chararray + _index + 1, strlen(this->chararray + _index));
	   }

	   //it frees the string inside
	   void clear(){
	        if(chararray) 
			    free(chararray);
	   }

	   //reverse the string
	   void reverse(){
	      strrev(this->chararray);
	   }
	   
	   //Returns the letter of the selected string
	   //variable[1] => return the letter from position 1
	   char operator[](int index){
	      return chararray[index];
	   }

	   //This is a copy operator.
	   //e.g string_unsafe obj1 = "hello"; 
	   //    string_unsafe obj2 = obj1;
	   //    printf("%s", obj2.c_str());
	   string_unsafe operator=(const string_unsafe &obj){
		   if(this == &obj) return *this;
		   free(this->chararray);
		   this->Alloc(obj.chararray);
	       return *this;
	   }

	   //attribution from BSTR to string_unsafe
	   //Alloc method - malloc
	   string_unsafe operator=(const BSTR& obj){
	       free(this->chararray);
		   char* tmp = _com_util::ConvertBSTRToString(obj); //convert to char* and alloc to string_unsafe
		   if(tmp) {
			   this->Alloc(tmp);
			   return *this;
		   }
		   this->Alloc(nullptr);
		   return *this;
	   }

	   //operator + with string_unsafe and char*
	   friend string_unsafe operator+(string_unsafe str1, const char* str){
	        return str1 + string_unsafe(str);
	   }

	   //operator + with char* and string_unsafe
	   friend string_unsafe operator+(const char* str, string_unsafe str1){
	        return string_unsafe(str) + str1;
	   }

	   //operator + with string_unsafe and string_unsafe
	   friend string_unsafe operator+(const string_unsafe& a, const string_unsafe& b){
		    char* __buffer = (char*) malloc(strlen(a.chararray) + strlen(b.chararray) + 1);
			strcpy(__buffer, a.chararray);
			strcat(__buffer, b.chararray);
			__buffer[strlen(a.chararray) + strlen(b.chararray)] = '\0';
		    string_unsafe __tmp{__buffer};
			free(__buffer);
			return __tmp;
	   }

	   //removes the first character from a string
	   //e.g: abcd => bcd
	   string_unsafe operator++(){
		    this->erase(0);
			return *this;
	   }

	   //increases the string with 1 position ex abcd -> bcd
	   string_unsafe operator++(int){
		    this->erase(0);
			return *this;
	   }

	   //comparator function with const char*
	   friend bool operator==(string_unsafe str1, const char* str){
	        return !strcmp(str1.chararray, str);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator==(string_unsafe str1, string_unsafe str2){
	        return !strcmp(str1.chararray, str2.chararray);
	   }
	   
	   //comparator function with const char*
	   friend bool operator!=(string_unsafe str1, const char* str){
	        return !(str1 == str);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator!=(string_unsafe str1, string_unsafe str2){
	        return !(str1 == str2);
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator<(string_unsafe str1, string_unsafe str2){
	        return strcmp(str1.chararray, str2.chararray) < 0;
	   }

	   //comparator function between 2 string_unsafe objects
	   friend bool operator>(string_unsafe str1, string_unsafe str2){
	        return !(str1 < str2);
	   }

	   //Alloc with malloc and converts from string_unsafe to char*
	   char* c_str(){
		  char* tmp = (char*)malloc(strlen(chararray) + 1);
		  strcpy_s(tmp, strlen(chararray) + 1, chararray);
	      return tmp;
	   }

	   //Converts from string_unsafe to BSTR / OLECHAR*
	   BSTR b_str(){
		   char* tmp = (char*)malloc(strlen(chararray) + 1);
		   strcpy_s(tmp, strlen(chararray) + 1, chararray);
	       BSTR tmpBSTR = _com_util::ConvertStringToBSTR(tmp);
		   free(tmp);
		   return tmpBSTR;
	   }
};