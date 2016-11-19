#include <iostream>
using namespace std;

int main()
{
	int *p;
	int a = 5;
	p = &a;
	std::cout << *p << std::endl;
	cin.get();
	return 0;
}