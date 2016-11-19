#include<iostream>
#include<string>
using namespace std;
struct encodeX
{
	string e1[64][1] = { {"A"}, {"B"}, {"C"}, {"D"} };
};
struct decodeX
{
	char e2[64][1];
};
void encode(void);
void decode(void);
void main()
{
	int num;
	cout << "ÇëÑ¡ÔñÄãµÄ²Ù×÷" <<"1.±àÂë" <<"2.½âÂë" <<endl;
	cin >> num;
	switch (num)
	{
	case 1:encode();
	case 2:decode();
	default:
		break;
	}
	
	
	
}


void encode(void)
{
	int j = 64;
	encodeX en;
	/*for (int i = 0; i < 64; i++)
	{
		
		en.e1[i][1] = ;
		j++;
		
		
	}*/
	
	for (int i = 0; i < 64; i++)
	{
		cout<< en.e1[i][1] << endl;
	}
}
void decode(void)
{
	;
}