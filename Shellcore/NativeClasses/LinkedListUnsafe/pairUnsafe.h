#pragma once

template <class T, class U>
class pair_unsafe{
public:
	T first;
	U second;
	
	pair_unsafe(){

	}

	pair_unsafe(T first, U second){
	   this->first = first;
	   this->second = second;
	}
	
	template <class T, class U>
	static pair_unsafe make_pair(T first, U second){
	    return pair_unsafe(first, second);
	}
};