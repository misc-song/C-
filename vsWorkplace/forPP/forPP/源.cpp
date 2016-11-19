#include<iostream>
using namespace std;
void main(void)

{
	int array[5] = { 1, 2, 3, 4, 5 };
	for (int x : array)
	{
		cout << x << endl;
	}
	cin.get();
}