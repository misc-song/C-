#include <iostream>
#include <string>  

using namespace std;

int add_fun(int n, int &sum);//引用

int main()
{
	int sum = 0;
	int n = 100;
	cout << "1+2+3+...+n的值为:" << add_fun(n, sum) << endl;
	return 0;
}

int add_fun(int n, int &sum)
{
	n && add_fun(n - 1, sum);
	return (sum += n);
}

