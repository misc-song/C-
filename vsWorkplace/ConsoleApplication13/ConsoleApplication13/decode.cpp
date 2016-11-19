#include<iostream>
#include<string>
using namespace std;
int decode[10];
int temp[10];
void main(void)
{
	/*int a = 242;
	int b = a << 2;
	int c = b-10;
	cout << c;*/

	for (int i = 0; i < 10; i++)
	{
		cout << "ÇëÊäÈë";
		cin >> decode[i];
		temp[i] = (decode[i] << 2)*3+10;

	}
	for (int i = 0; i < 10; i++)
	{
		cout << temp[i]<<endl;
	}

	getchar();
}