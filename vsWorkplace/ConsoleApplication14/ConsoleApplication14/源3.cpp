#include<iostream>
using namespace std;
void main()
{
	int a = 25;
	int b = 1;
	for (int i = 0; i < 8; i++)
	{
		
		int c = a&b;
		c = c >> i;
		cout << c;
		b = b << 1;
	}
}