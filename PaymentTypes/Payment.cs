using System;

namespace ConsoleApplication
{
    public class Payment
    {
    //adding some things that are common to all payment types:
     
    public decimal Amount {get; set;} 

    //creating a new method: virtual allows for the class to be overwritten.  This is a base class that will be derived later.
    public virtual string MakePayment()
    {
        //TODO: hit the payment processing API
        return "You paid ${this.amount} in Cash";
    }

    public string SendConfirmation(string email)
    {
        return "You purchased several nice items";
    }
    public string SendConfirmation(string email, bool digitalDownload)
    {
        return "Check your email for the downloadable book";
    }

}
}