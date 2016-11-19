#include<iostream>
using namespace std;

void main()
{
	enum 
	{
		yellow,
		black,
		red,
		white,
		bule
	};
	cout << "请输入一个数字" << endl;
	int color;
	cin >> color;

	switch (color)
	{
	case yellow:
		cout << "黄色" << endl;
		break;
	case black:
		cout << "黑色" << endl;
		break;
	case red:
		cout << "红色" << endl;
		break;
	case white:
		cout << "白色" << endl;
		break;
	case bule:
		cout << "蓝色" << endl;
		break;
	default:
		break;
	}

}