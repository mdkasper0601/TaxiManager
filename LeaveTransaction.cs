using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagementAssignment
{
     public class LeaveTransaction : Transaction 
    {
        public int taxiNum;
        public int rankId;
        public string destination;
        public double agreedPrice;
        public LeaveTransaction(DateTime transactionDatetime, int rankid ,Taxi t) : base("Leave", transactionDatetime)
        {
            this.rankId = rankid;
            taxiNum = t.Number;
            destination = t.Destination;
            agreedPrice = t.CurrentFare;
        }

        public override string ToString()
        {
            string dateStr = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            return dateStr + $" Leave     - Taxi {taxiNum} from rank {rankId} to {destination} for £{agreedPrice}";
        }
    }
}
