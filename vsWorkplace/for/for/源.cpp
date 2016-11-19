#include<iostream>
const int num = 21;//声明并初始化静态变量num

int main(void)//main函数整个程序的入口 实际上可能并不是这样
{
	using namespace std;//使用using命令 使用"namespace"名称空间 
	
	long long array[num];//创建一个lang lang型的数组 重点是能保存20!的值 其他类型会导致内存的溢出

	array[0] = array[1] = 1LL;//将数组进行赋值 由于0! 和1!的值都为1  规定0!=1 1LL 代表的是lang lang型的数据
	for (int i = 2; i < num; i++)//
	{
		array[i] = i*array[i - 1];//使用for循环对每个值进行运算和保存
	}
	for (int i = 0; i < num; i++)//使用for循环将每个值输出
	{
		cout << i << "i is:" << array[i] << endl;//遍历数组
	}
	cout << endl << endl;
	/*
	for (int i = 0; i < 5; i +=3)
	{
		cout << i << endl;
	}
	*/
	
	int j = 5;
	while (j++<9)
	{
		cout << ++j << endl;
	}
	cin.get();//相当于C语言中的getchar() 等待用户进行键入Enter
	return 0;//程序结束返回0
}