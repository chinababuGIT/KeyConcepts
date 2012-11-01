// EncapInheritancePolymor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>


int _tmain(int argc, _TCHAR* argv[])
{
	
	
	const char* p = "1234456";
	char* q = new char[10]();
	

	char* const pi= "123456";
	p = "131";
	pi = q;

	std::cout << "Hellow World" << std::endl;
	return 0;
}

