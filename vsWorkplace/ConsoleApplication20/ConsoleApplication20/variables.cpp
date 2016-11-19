#include<iostream>
using namespace std;
int number = 23;
void main()
{
	int number = 25;
	cout << "全局的number是" << ::number << endl;
	cout << "局部的number是" << number << endl;
	cin.get();
}