using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface IBeverage
    {
        // Methods, properties, events and indexers go here
        int GetServingTemperature(bool includesMilk);
        bool IsFairTrade { get; set; }

        event EventHandler OnSoldOut;
        string this[int index] { get; set; }
    }
}
