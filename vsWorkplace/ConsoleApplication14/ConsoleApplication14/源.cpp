#include<iostream>
#include<windows.h>
#include<string>
using namespace std;
#define A0 0
#define A1 1
#define A2 2
#define A3 3
#define A4 4
#define A5 5


void get_time(void);
void encode(void);
void decode(void);

void main(void)
{
	get_time();
	int select;
	cout << "选择你的操作 1.编码 2.解码:"<<endl;
	cin >> select;

	switch (select)
	{
	case 1:encode();
		break;
	case 2:decode();
		break;
	default:
		break;
	}
	cout << "程序运行结束"<<endl;

	
}
void get_time(void)
{
	int x;
	int now_time;
	int now_timeM;
	int now_timeH;
	SYSTEMTIME sys;
	GetLocalTime(&sys);
	now_timeM = sys.wMinute;
	now_timeH = sys.wHour;
	now_time = now_timeM + now_timeH;
	//cout << sys.wMinute;

	//int now_time;
	while (1)
	{
		cout << "请输入口令:"<<endl;
		cin >> x;
		
		if (now_time == x)
		{
			break;
		}
		else
		{
			cout << "口令错误请不要乱输入"<<endl;
			
		}

	}
}

void encode(void)
{
	cout << "请输入你需要编码的字符串";
	int temp;
	char x[255];
	cin >> x;
	int length = sizeof(x) / sizeof(char);
	for (int i = 0; i < length; i++)
	{
		if (x[i] == '\0')
		{
			temp = i;
			break;

		}
	}
	char *p = x;
	for (int i = 0; i < temp; i++)
	{
		int x = int(p[i]);
		int y = x & 240;
		int z = x & 15;
		z = z << 4;
		y = y >> 4;
		int f = z | y;
		//int k = (x>>4) | (x<<4);
		cout << "       " << x << endl;
		cout << "一层编码过后的结果为:" << f << endl;
		//cout << "输入的内容为" << int(p[i]) << endl;
		f = (f << 2) * 3 + 10;
		cout << "二层编码过后的结果为:" << f << endl;
		int code1 = f / 1000;
		int x1 = f % 1000;

		int code2 = x1 / 100;
		int x2 = x1 % 100;

		int code3 = x2 / 10;
		int x3 = x2 % 10;

		int code4 = x3 / 1;
		cout << "三层编码的结果为:" << endl;
		switch (code1)
		{

		case 0:
			cout << "**";
			break;
		case 1:
			cout << "*#";
			break;
		case 2:
			cout << "*/";
			break;
		case 3:
			cout << "*.";
			break;
		case 4:
			cout << "#*";
			break;
		case 5:
			cout << "##";
			break;
		case 6:
			cout << "#/";
			break;
		case 7:
			cout << "#.";
			break;
		case 8:
			cout << "/*";
			break;
		case 9:
			cout << "/#";
			break;
		default:
			break;
		}

		switch (code2)
		{

		case 0:
			cout << "**";
			break;
		case 1:
			cout << "*#";
			break;
		case 2:
			cout << "*/";
			break;
		case 3:
			cout << "*.";
			break;
		case 4:
			cout << "#*";
			break;
		case 5:
			cout << "##";
			break;
		case 6:
			cout << "#/";
			break;
		case 7:
			cout << "#.";
			break;
		case 8:
			cout << "/*";
			break;
		case 9:
			cout << "/#";
			break;
		default:
			break;
		}

		switch (code3)
		{

		case 0:
			cout << "**";
			break;
		case 1:
			cout << "*#";
			break;
		case 2:
			cout << "*/";
			break;
		case 3:
			cout << "*.";
			break;
		case 4:
			cout << "#*";
			break;
		case 5:
			cout << "##";
			break;
		case 6:
			cout << "#/";
			break;
		case 7:
			cout << "#.";
			break;
		case 8:
			cout << "/*";
			break;
		case 9:
			cout << "/#";
			break;
		default:
			break;
		}

		switch (code4)
		{

		case 0:
			cout << "**";
			break;
		case 1:
			cout << "*#";
			break;
		case 2:
			cout << "*/";
			break;
		case 3:
			cout << "*.";
			break;
		case 4:
			cout << "#*";
			break;
		case 5:
			cout << "##";
			break;
		case 6:
			cout << "#/";
			break;
		case 7:
			cout << "#.";
			break;
		case 8:
			cout << "/*";
			break;
		case 9:
			cout << "/#";
			break;
		default:
			break;
		}







		//cout << "code1:" << code1 << "   " << "code2:" << code2 << "   " << "code3:" << code3 << "   " << "code4:" << code4 << endl;
		//cout << "三层编码的结果为:" << endl;
	}
	

}
void decode(void)
{

	cout << "请输入你解码的编码(输入1退出程序):" << endl;
	while (1)
	{
		int input_number;
		cin >> input_number;
		if (input_number==1)
		{
			break;
		}
		int num = (input_number - 10) / 3;
		num = num >> 2;
		int y = num & 240;
		int z = num & 15;
		z = z << 4;
		y = y >> 4;
		int f = z | y;
		cout << f ;
		char m = char(f);
		cout <<"编码的结果是"<< m << endl;
		cout << "你可以继续输入代码,或者输入1退出这个程序" << endl;
	}

}
