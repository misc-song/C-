#include <iostream>
using namespace std;
int a,b,i=0;

void main()
{
	/*int *score = new int[];
	score[0] = 12;
	score[1] = 14;
	score[2] = 16;*/
	//for (int i = 0; i < 10; i++)
	//{
	//	cout << score[i] << endl;
	//	
	//}
	
	//cout <<a<<endl ;


	/*int arr[] = { 12, 48, 87, 87, 87 };
	a = sizeof(arr) / sizeof(int *);

	cout <<a<<endl ;*/

	int *score = new int[];
	score[0] = 12;
	score[1] = 14;
	score[2] = 16;
	score[3] = 0;
	for (i = 0; i < 10; i++)
	{
		if (score[i]==0)
		{
			break;
		}
		cout << score[i]<< endl;
		
	}
	cout << "数组的长度为:" << i <<"标记位为:"<<score[i]<<endl;
}