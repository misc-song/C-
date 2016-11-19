#include<iostream>
using namespace std;

int recursion(int n, int & res);

void main()
{
	int num=5;

	int res = 1;
	cout << recursion(num, res);
}

int recursion(int n, int & res)
{	
	cout << res << endl;
	n && (recursion(n - 1, res));//ÓÐÎÊÌâ°¡
	
	return (res + = n);
}