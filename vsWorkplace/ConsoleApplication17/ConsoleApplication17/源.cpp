#include<iostream>
#include<string>
using namespace std;

void change1(void);
void change2(void);
void main()
{
	/*using std::cout;
	using std::cin;
	using std::endl;*/
	int select;
	cout << "调换单词倒序  1.方法一;2.方法二" << endl;
	cin >> select;
	switch (select)
	{
	case 1:
		change1();
		break;
	case 2:
		change2();
		break;
	default:
		break;
	}

	cin.get();

}
void change1()
{
	cout << "请输入一个单词" << endl;
	string word;
	cin >> word;

	for (int i = word.size() - 1; i >= 0; i--)
	{
		cout << word[i];
	}
}
void change2()
{
	cout << "请输入一个单词" << endl;
	string word;
	cin >> word;

	//int i;
	int j = word.size()-1;
	for (int i = 0; i < (word.size()+1) / 2; i++, j--)
	{
		char temp;
		temp = word[i];
		word[i] = word[j];
		word[j] = temp;
	

	}
	cout << word << endl;
}

