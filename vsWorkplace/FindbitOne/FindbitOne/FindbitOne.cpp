#include<iostream>

using namespace std;

void main()
{
	cout << "������һ������" << endl;
	int num;
	cin >> num;
	int count = 0;
	while (num!=0)
	{
		if ((num & 1)==1)
		{
			count++;
		}
		num >>= 1;
		
	}
	cout << count << endl;

	//cin.get();

}