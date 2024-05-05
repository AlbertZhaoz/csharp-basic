<Query Kind="Program" />

delegate void Callback();

void Main()
{
	HeavyJob(CallbackImp);
}

void HeavyJob(Callback callBack)
{
	Thread.Sleep(1000);

	callBack?.Invoke();
}

void CallbackImp()
{
	"Job Done".Dump();
}