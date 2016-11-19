#include<iostream>
using namespace std;
int compare(int a[], int b);
void main(void)
{
	int b[6] = {12,34,57,39,23,56}, x, result;
	x = sizeof(b) / sizeof(int);
	result = compare(b, x);
	cout << x << endl;
	cout << "最大值为：" << result << endl;
}
int compare(int a[], int b)
{
	int temp = 0;
	for (int i = 0; i < b; i++)
	{
		if (temp<a[i])
		{
			temp = a[i];
		}
	}
	return temp;
}