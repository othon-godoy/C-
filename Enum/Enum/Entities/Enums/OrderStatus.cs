using System;
using System.Collections.Generic;
using System.Text;

namespace Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 1,
        Processing,
        Shipped,
        Delivered
    }
}
