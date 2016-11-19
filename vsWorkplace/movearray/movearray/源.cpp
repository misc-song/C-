#include<iostream>
using namespace std;


void main()
{
	//int *array = new int[];
	//int length;
	//cout << "please input array length:" << endl;
	//cin >> length;
	//for (int  i = 0; i < length; i++)
	//{
	//	cout << "please input your array member:" << endl;
	//	cin >> array[i];
	//}
	//for (int i = 0; i < length; i++)
	//{
	//	cout << "your array member is:" << endl << array[i] << endl;
	//}
	//delete[]array;

	int array[5] =
	{
		1,
		2,
		3,
		4,
		5
	};
	for (int x:array)
	{
		cout << x << endl;
	}
	cin.get();


}