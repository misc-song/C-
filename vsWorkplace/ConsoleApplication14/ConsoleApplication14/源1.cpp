#include<iostream>
#include<string>
using namespace std;

void main()
{
	int temp;
	char x[255];
	cin >> x;
	int length = sizeof(x) / sizeof(char);
	for (int i = 0; i < length; i++)
	{
		if (x[i]=='\0')
		{
			temp = i;
			break;

		}
	}
	char *p=x;
	for (int i = 0; i < temp; i++)
	{
		int x = int (p[i]);
		int y = x&240;
		int z = x&15;
		z = z<< 4;
		y = y >> 4;
		int f = z | y;
		//int k = (x>>4) | (x<<4);
		cout << x << endl;
		cout << "一层编码过后的结果为:" << f << endl;
		//cout << "输入的内容为" << int(p[i]) << endl;
		f = (f << 2) * 3 + 10;
		cout << "二层编码过后的结果为:" << f << endl;

		cout << "第三层编码的结果为:" << "待开发" << endl;
	}
}