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
	cout << "ѡ����Ĳ��� 1.���� 2.����:"<<endl;
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
	cout << "�������н���"<<endl;

	
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
		cout << "���������:"<<endl;
		cin >> x;
		
		if (now_time == x)
		{
			break;
		}
		else
		{
			cout << "��������벻Ҫ������"<<endl;
			
		}

	}
}

void encode(void)
{
	cout << "����������Ҫ������ַ���";
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
		cout << "һ��������Ľ��Ϊ:" << f << endl;
		//cout << "���������Ϊ" << int(p[i]) << endl;
		f = (f << 2) * 3 + 10;
		cout << "����������Ľ��Ϊ:" << f << endl;
		int code1 = f / 1000;
		int x1 = f % 1000;

		int code2 = x1 / 100;
		int x2 = x1 % 100;

		int code3 = x2 / 10;
		int x3 = x2 % 10;

		int code4 = x3 / 1;
		cout << "�������Ľ��Ϊ:" << endl;
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
		//cout << "�������Ľ��Ϊ:" << endl;
	}
	

}
void decode(void)
{

	cout << "�����������ı���(����1�˳�����):" << endl;
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
		cout <<"����Ľ����"<< m << endl;
		cout << "����Լ����������,��������1�˳��������" << endl;
	}

}
