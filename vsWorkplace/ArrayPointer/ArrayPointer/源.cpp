#include<iostream>

void main()
{
	
	double number[5] = {3.5,6.7,9.9,88,7};
	double *p;
	p = number;
	std::cout << *p++ << std::endl;
	p = number;
	std::cout << ++*p << std::endl;
	p = number;
	std::cout << *++p << std::endl;
	p = number;
	std::cout << ++p <<*p<< std::endl;
	
}