#include<iostream>
#include<cstring>

using namespace std;

int main(void)
{
	int* p1 = new int;
	int* p2 = new int;
	
	int number1 = 5;
	int number2 = 6;
	//p1 = &number1;
	//p2 = &number2; //这种写法是无法调用delete 来释放内存的 当将内存的地址重新取址后delete将不再适用
	*p1 = number1;
	*p2 = number2;
	cout << *p1 << *p2 << endl;
	
	delete p1;//释放p1内存
	delete p2;//释放p2的内存
	p1 = NULL;//将p1指针赋值为空
	p2 = NULL;//将p2的指针赋值为空
	/*如果指针指向的不是new分配的内存地址，则该指针上使用delete是不合法的。例如，
	int i;
	int *pi = &i;
	delete pi;
	上述语句是错误的，i是分配在栈上，栈上的内存不需也不能调用delete删除。*/
	return 0;
}