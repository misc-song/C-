#include<iostream>
using namespace std;

void main(void)
{
	int num;
	cout << "请输入三角形的层数" << endl;
	cin >> num;
	int temp = num;
	for (int i=0; i <num; i++)
	{
		temp--;
		for (int j=temp; j >= 0 ; j--)
		{
			cout << "*"; 
		}
		
		cout << endl;
	}
}