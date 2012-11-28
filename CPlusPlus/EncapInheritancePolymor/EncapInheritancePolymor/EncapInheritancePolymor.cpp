// EncapInheritancePolymor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <algorithm>
#include <vector>
#include <array>

void StorePrintVector();

int _tmain(int argc, _TCHAR* argv[])
{
	
	const char* p = "654321";
	char* q = new char[10]();
	
	char* const pi= "123456";
	p = "131";
	//strcpy(pi,p);
	std::cout << "Hellow World" << std::endl;

	StorePrintVector();

	std::cin;
	

	return 0;
}

void StorePrintVector()
{
	std::vector<int> integerVector;
	for(int i=1;i<=1000;++i)
		integerVector.push_back(i);	`
	//integerVector.begin();
	for(std::vector<int>::const_iterator it= integerVector.begin();
		it != integerVector.end();
		++it)
	{
		std::cout<<*it<<std::endl;
	}
}

class TestSTL
{
public:
	TestSTL(){};
	~TestSTL(){};
private:
	TestSTL(TestSTL& other);
	TestSTL& operator=(const TestSTL& rhs);
	//TestSTL operator=(const TestSTL rhs);

};


