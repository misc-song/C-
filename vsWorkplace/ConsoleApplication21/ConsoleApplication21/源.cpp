#include<iostream>
using namespace std;
void main()
{
	int x = 1;
	int a = 0;
	int b = 0;
	switch (x)
	{
	case 0:
		b++;
	case 1:
		a++;
	case 2:
		a++;
		b++;
	default:
		break;
	}
	cout << a << b << endl;
}