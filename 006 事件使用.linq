<Query Kind="Program" />

void Main()
{
	// 注册事件，当 Value 值发生变化时候，可以通过注册的事件观测到
	var demoViewModel = new DemoViewModel();
	demoViewModel.NotifyPropertyChanged += () => "PropertyChanged".Dump();
	demoViewModel.MyValue = 666;
}


class DemoViewModel{
	int _myValue;
	
	public int MyValue
	{
		get { return _myValue; }
		set { 
			_myValue = value;
			NotifyPropertyChanged?.Invoke();
		}
	}
	
	public event Action NotifyPropertyChanged;
	
}

