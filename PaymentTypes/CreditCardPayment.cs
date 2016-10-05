using System;

namespace ConsoleApplication
{
    //this is how inhertiance works in C#, where PayPalPayment inherits the properties of Payment
    public class CreditCardPayment:Payment
    {
        public string CreditCardNumber {get; set;}

        //when overriding the arguments need to be spelled exactly the same!
        public override string MakePayment()
        {
            string message= string.Empty;
            if (this.Amount>0 && this.CreditCardNumber!=null)
            {
                message= $"Your payment of {this.Amount} has been processed by Visa/MasterCard";
            }
            
            return message;
        }

    }
}