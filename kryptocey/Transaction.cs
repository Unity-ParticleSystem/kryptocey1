using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Utils;


namespace Models
{

    public class Transaction
    {
        
        public long TimeStamp { get; set; }
        public string Sender { set; get; }
        public string Recipient { set; get; }
        public double Amount { set; get; }
        public double Fee { set; get; }
    }

}