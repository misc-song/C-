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
	cout << "������һ������" << endl;
	int color;
	cin >> color;

	switch (color)
	{
	case yellow:
		cout << "��ɫ" << endl;
		break;
	case black:
		cout << "��ɫ" << endl;
		break;
	case red:
		cout << "��ɫ" << endl;
		break;
	case white:
		cout << "��ɫ" << endl;
		break;
	case bule:
		cout << "��ɫ" << endl;
		break;
	default:
		break;
	}

}