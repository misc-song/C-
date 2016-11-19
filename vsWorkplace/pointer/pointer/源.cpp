#include<iostream>
using namespace std;
void change(int,int);
void main(void)
{
	//int number = 6;
	//int *p;							//*p = number;
	//p = &number;
	//cout << "number is:" << number << endl;
	//cout << "&number is:" << &number << endl;
	//cout << "*p is:" << *p << endl;
	//cout << "p is:" << p << endl;
	//cin.get();

	int a = 1;
	int b = 2;
	change(a, b);
	//cin.get();
}

void change(int num1,int num2)
{
	int* p1 = new int;
	int* p2 = new int;
	int* p_temp=new int;
	p1 = &num1;
	p2 = &num2;
	cout << "before num1 is:" << *p1<< "   " << "num2 is:" << *p2 << endl;
	p_temp = p1;
	p1 = p2;
	p2 = p_temp;
	cout << "after num1 is:" << *p1 << "   " << "num2 is:" << *p2 << endl;
	delete p1;
	delete p2;
	delete p_temp;
	//return 0;
}


