#include <iostream>
#include <string>  

using namespace std;

int add_fun(int n, int &sum);//����

int main()
{
	int sum = 0;
	int n = 100;
	cout << "1+2+3+...+n��ֵΪ:" << add_fun(n, sum) << endl;
	return 0;
}

int add_fun(int n, int &sum)
{
	n && add_fun(n - 1, sum);
	return (sum += n);
}

