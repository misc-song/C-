#include<stdio.h>
#include<iostream>
void main()
{
	int m, i, j;
	for (i = 1; i<9; i++)
	{
		for (j = 1; j<9; j++)
		{
			for (m = 32; m<100; m++)
			{
				if (m*m == (1000 * i + 100 * i + 10 * j + j))
				{
					
					std::cout << i << i << j << j;
				}
			}
		}
	}
	getchar();
}
/*string year=null
while(!(year=Console.ReadLine()).Equals("0")){
int i=Convert.ToInt32(year);
if(i<0){
continue;
}
if(year % 400 == 0||year % 4 == 0 && year % 100 != 0)
{
Console.WriteLine(year);
}
}
Console.WriteLine("½áÊø");*/