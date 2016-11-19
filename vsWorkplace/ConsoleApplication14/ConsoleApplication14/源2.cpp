#include<iostream>
#include<windows.h>
using namespace std;
int x;
void main()
{
	
	int now_time;
	SYSTEMTIME sys;
	GetLocalTime(& sys);
	now_time = sys.wMinute;
	//cout << sys.wMinute;

	//int now_time;
	while (1)
	{
		cin >> x;
		if (now_time==x)
		{
			break;
		}

	}
	cout << "程序运行结束";

}