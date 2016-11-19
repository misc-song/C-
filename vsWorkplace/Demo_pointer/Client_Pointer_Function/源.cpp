#include<iostream>
double betsy(int);
double pam(int);


void  estimate(int lines, double(*pf)(int));

int main()
{
	using namespace std;

	int code;
	cout << "How many lines of code do you need?\n";
	cin >> code;
	cout << "Here Betsy estimate:\n";
	estimate(code, betsy);
	cout << "Here's pam estimate:\n";
	estimate(code, pam);
	return 0;
}
double betsy(int lns)
{
	return 0.05 * lns;
}
double pam(int lns)
{
	return 0.03 * lns + 0.0004*lns*lns;
}
void estimate(int lines, double(*pf)(int))
{
	using namespace std;
	cout << lines << "Lines will take";
	cout << (*pf)(lines) << "hours(s)\n";
}