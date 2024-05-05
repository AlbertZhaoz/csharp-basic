<Query Kind="Program" />

void Main()
{
	// 匿名委托
	PickOne(10, 20, delegate (int a, int b) {return true;}).Dump();
	// Lambda 表达式
	PickOne(10, 20, (a, b) => true).Dump();
}


int PickOne(int a, int b, Func<int, int, bool> rule)
{
	if (rule(a, b)) return a;
	else return b;
}


