#include <iostream>
using namespace std;
int c,d,e,f;


int main()
{

	int a = 0x73;
	int b = 0xff;
	c = a & b;
	d = a | b;
	e = a^b;
	f = ~b;
	std::cout << std::hex << "c��ֵΪ" << c << endl
		<< "d��ֵΪ" << d << endl
		<< "e��ֵΪ" << e << endl 
		<< "f��ֵΪ" << f << endl;
	getchar();
	return 0;
}

