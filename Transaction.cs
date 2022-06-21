using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagementAssignment
{
    public class Transaction
    {
        public DateTime TransactionDatetime;
        public string TransactionType;
        public Transaction(string type, DateTime dt) 
        {
            TransactionType = type;
            TransactionDatetime = dt;
        }
  
    }
}
