#include<iostream>
/**********************************************/
/*
/*
/*
/**********************************************/
using namespace std;

void change_num1(int, int);
void change_num2(int *p,int *q);
void change_num3(int & p, int & q);

int num1 = 100;
int num2 = 234;

void main()
{

	cout << "初始值:" << endl << "num1:" << num1 << endl << "num2:" << num2 << endl;
	change_num1(num1, num2);

	cout << "交换过后的值:" << endl << "num1:" << num1 << endl << "num2:" << num2 << endl;

	change_num2(&num1, &num2);

	cout << "交换过后的值:" << endl << "num1:" << num1 << endl << "num2:" << num2 << endl;

	change_num3(num1, num2);

	cout << "交换过后的值:" << endl << "num1:" << num1 << endl << "num2:" << num2 << endl;
}

void change_num1(int a, int b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}
void change_num2(int *p, int *q)
{
	int temp;
	temp = *p;
	*p = *q;
	*q = temp;
}

void change_num3(int & a, int & b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}