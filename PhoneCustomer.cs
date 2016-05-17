using System;


class PhoneCustomer
{
    public const string DayOfSendingBill = "Monday";
    public int CustomerID;
    public string FirstName;
    public string LastName;    
    
    public string FullName
    {
        return this.FirstName + this.LastName;
    }
}


namespace TeaFish
{
    class MainEntryPoint
    {
        static void Main()
        {
            PhoneCustomer Customer1 = new PhoneCustomer();
            Customer1.FirstName = "Simon";
        }
    }
}







