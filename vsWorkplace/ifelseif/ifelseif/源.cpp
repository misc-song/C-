#include<stdio.h> 
#include<math.h> 
int main() 
{  
	double y; 
	int x,m;  
	for(y=1;y>=-1;y-=0.1) /*yΪ�з���ֵ��1��-1������Ϊ0.1*/ 
	{  
		m=acos(y)*10; /*�����y��Ӧ�Ļ���m������10Ϊͼ�ηŴ���*/ 
		for(x=1;x<m;x++) 
			printf(" "); 
		printf("*"); /*���ƴ�ӡ���� * ��*/ 

		for(;x<62-m;x++)
			printf(" ");  
		printf("*\n"); /*���ƴ�ӡͬһ���жԳƵ��Ҳ�*��*/ 
	} 
	return 0;  
}