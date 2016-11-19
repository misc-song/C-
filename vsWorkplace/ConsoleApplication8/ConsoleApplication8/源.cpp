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
	std::cout << std::hex << "c的值为" << c << endl
		<< "d的值为" << d << endl
		<< "e的值为" << e << endl 
		<< "f的值为" << f << endl;
	getchar();
	return 0;
}

