#include <iostream>
using namespace std;
int itor(int a);


void main(void)
{
	cout << itor(1) << endl;
}
int itor(int a)
{
	return a + itor(a + 1);


}