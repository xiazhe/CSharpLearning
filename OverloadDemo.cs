// 重载
class ResultDisplayer
{
    void DisplayerResult(string result)
    {
        //implementation
    }
    
    void DisplayerResult(int result)
    {
        //implementation
    }
}

// 不同个数参数重载
class MyClass
{
    void DoSomething(int x)
    {
        DoSomething(x, 10);
    }
    
    void DoSomething(int x, int y)
    {
        //implementation
    }
}