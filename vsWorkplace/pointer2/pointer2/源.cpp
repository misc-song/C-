#include<iostream>
#include<cstring>

using namespace std;

int main(void)
{
	int* p1 = new int;
	int* p2 = new int;
	
	int number1 = 5;
	int number2 = 6;
	//p1 = &number1;
	//p2 = &number2; //����д�����޷�����delete ���ͷ��ڴ�� �����ڴ�ĵ�ַ����ȡַ��delete����������
	*p1 = number1;
	*p2 = number2;
	cout << *p1 << *p2 << endl;
	
	delete p1;//�ͷ�p1�ڴ�
	delete p2;//�ͷ�p2���ڴ�
	p1 = NULL;//��p1ָ�븳ֵΪ��
	p2 = NULL;//��p2��ָ�븳ֵΪ��
	/*���ָ��ָ��Ĳ���new������ڴ��ַ�����ָ����ʹ��delete�ǲ��Ϸ��ġ����磬
	int i;
	int *pi = &i;
	delete pi;
	��������Ǵ���ģ�i�Ƿ�����ջ�ϣ�ջ�ϵ��ڴ治��Ҳ���ܵ���deleteɾ����*/
	return 0;
}