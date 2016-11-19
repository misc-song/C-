#include<iostream>

using namespace std;

void main(void)
{
	//int number = 6;
	//int *pointer;
	//pointer = &number;
	//cout <<"*poiner的值为:"<<*pointer << endl;//符号*运算符代表着间接值或解除应用;
	//cout << "&pointer的值为:" << pointer << endl;//& 取pointer的地址
	//cout << "number的值为:" << number << endl;
	//cout << "number的地址为:" << &number << endl;
	//cin.get();
	cout<< "请输入一个字符" << endl;
	char a;
	a = cin.get();
	if ('\0'==a)
	{
		cout << "fuck you" << endl;
	}
	cout << "a的值为:" << a << endl;
	getchar();




}

