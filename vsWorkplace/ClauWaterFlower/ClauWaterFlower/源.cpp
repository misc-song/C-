#include<iostream>
#include<string>
#include<vector>
//#include <cstdlib>
//using namespace std;
void waterNumber(std::string str)
{
	std::vector<int> total;//����һ��vector���ڱ�����
	int count = str.size();//��ȡ�ַ����ĳ���

	std::vector<int> num;//����һ��vector���ڱ��� ����λ����n�η� ��λ���������η� ��λ������4�η� �Դ�����
	int totalNum = atoi(str.c_str());//��string����תΪint���� �������Ľ���Ƚ�

	for (int i = 0; i < count; i++)//ִ��ѭ����
	{
		num.push_back((int)str[i] - 48);//��char����תΪint��
		
		int k = 1;						//����һ����ʱ�������ڱ������λn�η��Ľ��
		for (int c = 0; c < count; c++)//ִ��ѭ������������λ����n�η������
		{
			k *= num[i];
		}

		total.push_back(k);//������λn�η���Ľ��������vector��
	}
	int temp;			//����һ����ʱ��������ѭ���ı���
	int result = 0;			//���岢��ʼ�����ڱ������յĽ��
	for (temp = 0; temp < count; temp++)//ѭ���������Ľ��
	{

		result += total[temp];

	}
	if (totalNum == result)
	{
		std::cout << "��ˮ�ɻ���";
		//Console.WriteLine("��ˮ�ɻ���"); ����c#�������

	}
	else
	{
		std::cout << "����ˮ�ɻ���";
		//Console.WriteLine("����ˮ�ɻ���"); ����c#�������

	}
}

void main(void)
{
	std::string str;
	std::cout << "������һ����:";
	std::cin >> str;
	waterNumber(str);
	std::cout << std::endl;
	std::cin.get();
	return;


}


