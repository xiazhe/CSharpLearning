class SomeProperty
{
    get
    {
        return "This is the property value.";
    }
    
    set
    {
        //do whatever needs to be done to be set the property.
    }
    
    private int age;
    
    public int Age 
    { 
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    
    
}