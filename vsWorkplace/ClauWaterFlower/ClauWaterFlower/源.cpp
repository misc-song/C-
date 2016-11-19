#include<iostream>
#include<string>
#include<vector>
//#include <cstdlib>
//using namespace std;
void waterNumber(std::string str)
{
	std::vector<int> total;//创建一个vector用于保存结果
	int count = str.size();//获取字符串的长度

	std::vector<int> num;//创建一个vector用于保存 各个位数的n次方 三位数就是三次方 四位数就是4次方 以此类推
	int totalNum = atoi(str.c_str());//将string类型转为int类型 用于最后的结果比较

	for (int i = 0; i < count; i++)//执行循环将
	{
		num.push_back((int)str[i] - 48);//将char类型转为int型
		
		int k = 1;						//创建一个临时变量用于保存各个位n次方的结果
		for (int c = 0; c < count; c++)//执行循环遍历将各个位数的n次方算出来
		{
			k *= num[i];
		}

		total.push_back(k);//将各个位n次方后的结果保存在vector中
	}
	int temp;			//声明一个临时变量进行循环的变量
	int result = 0;			//定义并初始化用于保存最终的结果
	for (temp = 0; temp < count; temp++)//循环计算最后的结果
	{

		result += total[temp];

	}
	if (totalNum == result)
	{
		std::cout << "是水仙花数";
		//Console.WriteLine("是水仙花数"); 这是c#流的输出

	}
	else
	{
		std::cout << "不是水仙花数";
		//Console.WriteLine("不是水仙花数"); 这是c#流的输出

	}
}

void main(void)
{
	std::string str;
	std::cout << "请输入一个数:";
	std::cin >> str;
	waterNumber(str);
	std::cout << std::endl;
	std::cin.get();
	return;


}


