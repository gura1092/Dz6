using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal interface ISellable
    {
        int Price { get; }
        void Sell(Character user);
    }
}
