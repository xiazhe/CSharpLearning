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

// PS: 两个方法不能仅在返回类型上有区别。两个方法不能仅根据参数是声明为ref还是out来区分。