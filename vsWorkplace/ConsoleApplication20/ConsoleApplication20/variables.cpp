#include<iostream>
using namespace std;
int number = 23;
void main()
{
	int number = 25;
	cout << "ȫ�ֵ�number��" << ::number << endl;
	cout << "�ֲ���number��" << number << endl;
	cin.get();
}