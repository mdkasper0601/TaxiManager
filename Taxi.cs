using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagementAssignment
{
    public class Taxi
    {
        
    
        public int Number { get; }
        public double CurrentFare { get; private set; } = 0;
        public string Destination { get; private set; } = "";
        public static string ON_ROAD = "on the road";
        public static string IN_RANK = "in_rank";
        public string Location { get; private set; } = ON_ROAD;
        public double TotalMoneyPaid = 0;
        private Rank rank = null;
        public Rank Rank
        { 
            get 
            { 
                return rank; 
            }

            set
            {
                if (Destination.Length > 0)
                {
                    throw new Exception("Cannot join rank if fare has not been dropped");
                }
                 else if (value is null)
                {
                    throw new Exception("Rank cannot be null");
                }
                else 
                {
                    rank = value;
                    Location = IN_RANK;
                }


            }
        }
        

        public Taxi(int num)
        {
            Number = num;        
        }

        public void AddFare(string destination, double agreedPrice)
        {
            Location = ON_ROAD;
            Destination = destination;
            CurrentFare = agreedPrice;
            rank = null;

        }

        public void DropFare( bool priceWasPaid)
        {
            if (priceWasPaid == false)
            {
                TotalMoneyPaid += 0;
            }else{
                Destination = "";
                Location = ON_ROAD;
                TotalMoneyPaid += CurrentFare;
                CurrentFare = 0;
                
            }
        }


    }

}
