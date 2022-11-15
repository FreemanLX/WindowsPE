#pragma once
#pragma warning(disable:4996)

#include <string.h>
//string_unsafe is the same like string class but is based on malloc and free functions
//So this is an unsafe class
//Usage: 
//  string_unsafe variable;
//  string_unsafe variable(const char*);
//  string_unsafe variable(char*);
//  string_unsafe variable(string_unsafe);
class string_unsafe
{
   //char array
   char* chararray;

   public:
	   //destructor
	   //Completely destroy the string
       ~string_unsafe(){
		    if(chararray != nullptr){
		        free(chararray);
				chararray = nullptr;
			}
	   }
	   //constructor
	   string_unsafe(){
	       chararray = (char*)malloc(sizeof(char) + 1);
		   chararray[0] = '\0';
	   }
	   //Object allocation
	   string_unsafe(char* costantchar){
		   if(costantchar == nullptr) {
		      	 chararray = (char*)malloc(sizeof(char) + 1);
		         chararray[0] = '\0';
				 return;
		   }
		   chararray = (char*)malloc(sizeof(char) * (strlen(costantchar) + 1));
	       strcpy_s(chararray, strlen(costantchar) + 1, costantchar);
		   //chararray[strlen(costantchar)] = '\0';
	   }
	   string_unsafe(wchar_t* wconstantchar){
		   size_t characters_converted = 0;
		   if(wconstantchar == nullptr) {
		      	 chararray = (char*)malloc(sizeof(char) + 1);
		         chararray[0] = '\0';
				 return;
		   }
		   size_t size = wcslen(wconstantchar) + 1;
	       chararray = (char*)malloc(size);
		   wcstombs_s(&characters_converted, chararray, size, wconstantchar, size - 1);
	   }
	   //Copy constructor
	   string_unsafe(string_unsafe &obj){
	        chararray = new char[strlen(obj.chararray) + 1];
		    strcpy_s(chararray, strlen(obj.chararray) + 1, obj.chararray);
		    //chararray[strlen(obj.chararray)] = '\0';
	   }
	   //Returns the size of the string
	   size_t Size(){
	      return strlen(chararray) + 1;
	   }
	   //Returns the length of the string
	   size_t Length(){
	      return strlen(chararray);
	   }
	   //Clears the string
	   void clear(){
	      chararray = (char*)malloc(sizeof(char) + 1);
		  chararray[0] = '\0';
	   }
	   //Checks if the string is empty
	   bool empty(){
	      return strlen(chararray) == 0;
	   }
	   //Returns the letter of the selected string
	   //variable[1] => return the letter from position 1
	   char operator[](int index){
	      return chararray[index];
	   }
	   //Concatenate operator for the same type objects
	   //E.g: 
	   //string_unsafe obj1("hello "), obj2("world");
	   //string_unsafe obj3 = obj1 + obj2; so the obj3 will be "hello world"
	   string_unsafe operator+=(string_unsafe& obj){
	        strcat_s(this->chararray, strlen(obj.chararray), obj.chararray);
			return *this;
	   }
	   //Concatante operator for const char* with string_unsafe
	   string_unsafe operator+=(const char* str){
	        strcat_s(this->chararray, strlen(str), str);
			return *this;
	   }
	   //Converts from string_unsafe to char*
	   char* toCharArray(){
	      return chararray;
	   }


	   //This is a copy operator.
	   //e.g string_unsafe obj1 = "hello"; 
	   //    string_unsafe obj2 = obj1;
	   //    printf("%s", obj2.toCharAarray());
	   string_unsafe operator=(const string_unsafe &obj){
		    this->chararray = new char[strlen(obj.chararray) + 1];
		    strcpy_s(this->chararray, strlen(obj.chararray) + 1, obj.chararray);
	        return *this;
	   }

};

