#pragma once
#pragma warning(disable:4996)


template <class __no_pointer_variable>
class Node{
private:
    __no_pointer_variable data;
	Node<__no_pointer_variable>* next;

public:
	Node(){
	   next = NULL;
	}
	Node(__no_pointer_variable data){
	   this->data = data;
	   next = NULL;
	}

	__no_pointer_variable GetData(){
	   return data;
	}

	Node<__no_pointer_variable>* getNext(){
	   return next;
	}

	void setNext(Node<__no_pointer_variable>* node){
	   next = node;
	}
};

//This is linkedlist class tehnically unsafe because it doesnt work on pointer arrays
//Usage:
//LinkedList_unsafe variable<int>();
//variable.push_back(int);
//
//
//LinkedList_unsafe variable<T>();
//variable.push_back(T);
//
//
//DO NOT USE:
//LinkedList_unsafe variable<T*>(); - will have the same value with the first element pushed
//variable.push_back(T*);

template <class __no_pointer_variable>
class LinkedList_unsafe
{
    Node<__no_pointer_variable>* elements;
	int elemcount;
	int elementsize;

public:
	LinkedList_unsafe(){
	   elements = NULL;
	   elemcount = 0;
	   elementsize = 0;
	}

	~LinkedList_unsafe(){
	    Node<__no_pointer_variable>* current = elements;
	    Node<__no_pointer_variable>* next = NULL;
 
		while (current != NULL)
		{
			next = current->getNext();
			delete current;
			current = next;
		}
		elements = NULL;
	}

	void push_back(__no_pointer_variable element){
        if (elements == NULL) elements = new Node<__no_pointer_variable>(element);
		else
		{
			Node<__no_pointer_variable>* last = elements; 
			while (last->getNext() != nullptr)
			{
				last = last->getNext();
			}
			last->setNext(new Node<__no_pointer_variable>(element));
		}
	    elemcount++;
		elementsize += sizeof(element); //just to be sure to get the elementsize
	}

	int Size(){
	    return elemcount;
	}

	int byteSize(){
	    return elementsize;
	}

	__no_pointer_variable* ToArray(){
        __no_pointer_variable* array = new __no_pointer_variable[elemcount];
		int i = 0;
		Node<__no_pointer_variable>* node = elements;
		while(node != NULL){
			array[i++] = node->GetData();
			node = node->getNext();
		}
		return array;
    }

};

