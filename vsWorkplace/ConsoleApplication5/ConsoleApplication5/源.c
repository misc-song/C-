#include <stdio.h>
int main()  {
	int i;
	int *p;
	int a[5] = { 0, 1, 2, 3, 4 };
	p = &a[0];
	printf("please enter 5 int numubers");
	for (i = 4; i < 10; i++)
	{
		printf("%d\n", p);
		p += 1;
	}
	getchar();
}

