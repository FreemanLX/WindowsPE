#include "pch.h"
#include "stringUnsafe.h"

#pragma warning(disable:4996)
inline bool operator==(string_unsafe obj1, string_unsafe obj2){
	 return strcmp(obj1.toCharArray(), obj2.toCharArray()) == 0;
}

