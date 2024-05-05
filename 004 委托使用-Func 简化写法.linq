<Query Kind="Program" />

void Main()
{
	PickOne(10, 20, MyRuleImp1).Dump();
	PickOne(10, 20, MyRuleImp2).Dump();
}


int PickOne(int a, int b, Func<int,int,bool> rule)
{
	if (rule(a, b)) return a;
	else return b;
}

bool MyRuleImp1(int a, int b)
{
	return true;
}

bool MyRuleImp2(int a, int b)
{
	return false;
}


