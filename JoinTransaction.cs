using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagementAssignment
{
    public class JoinTransaction : Transaction
    {
        public int taxiNum;
        public int rankId;


        public JoinTransaction(DateTime transactionDatetime, int taxinum, int rankid) : base("Join", transactionDatetime)
        {
            this.taxiNum = taxinum;
            this.rankId = rankid;
        }

        public override string ToString()
        {
            string dateStr = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            return dateStr + " Join      - Taxi " + taxiNum + " in rank " + rankId;

        }
    }
}
