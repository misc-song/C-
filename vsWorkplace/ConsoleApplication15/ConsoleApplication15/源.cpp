#include<iostream>
#include<String>

using namespace std;

struct  People
{
	string name;
	int age;
	char sex;
};
enum bits
{
	one = 1, two = 2, three = 3
};
void main(void)
{
	//People zhangsan;
	//zhangsan.age = 25;
	//zhangsan.name = "ZHANGSAN";
	//zhangsan.sex = 'm';
	//cout << "the age is:" << zhangsan.age << endl;
	//cout << "the name is:" << zhangsan.name << endl;
	//cout << "the sex is:" << zhangsan.sex << endl;
	People lisi
	{
		"lisi",
		25,
		'm'
	};
	cout << "the age is:" << lisi.age << endl;
	cout << "the name is:" << lisi.name << endl;
	cout << "the sex is:" << lisi.sex << endl;
	bits j;
	cout <<"JµÄÖµÎª"<< j;

}
