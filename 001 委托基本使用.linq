<Query Kind="Program" />

delegate void FooDelegate();
delegate string FooInputDelegate(int num);

void Main()
{
	var fooDelegate = new FooDelegate(FooImp1);
	fooDelegate += FooImp2;
	
	// 委托如果 -= 里面没有任何函数就会为空
	fooDelegate?.Invoke();
	
	var fooInputDelegate = new FooInputDelegate(FooImp2);
	fooInputDelegate(66).Dump();
}


void FooImp1()
{
	"Foo1".Dump();
}

void FooImp2()
{
	"Foo2".Dump();
}

string FooImp2(int num){
	return (num+1).ToString();
}