using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}
