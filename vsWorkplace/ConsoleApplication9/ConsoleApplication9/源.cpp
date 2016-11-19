#include<iostream>
using namespace std;
void main(void)
{
	int max = 100;
	bool flags[100];
	int primes[25];
	int pi = 0;
	for (int  m = 2; m < max; m++)
	{
		if (flags[m])
		{
			primes[pi++] = m;
			for (int n = 0; n < max; n+=m)
			{
				flags[n] = false;
			}
		}

	}

	for (int x = 0; x < 26; x++)
	{
		cout << "素数为" <<primes[x] << "标志为" <<flags[x]<< endl;
		if (2==primes[x])
		{
			cout << "A" << endl;
		}
	}
	getchar();

}