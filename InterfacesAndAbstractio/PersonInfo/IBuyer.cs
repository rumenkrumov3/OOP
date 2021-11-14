using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IBuyer
    {
        public void BuyFood();

        public int Food { get; set; }
    }
}
