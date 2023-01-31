using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Drink : Product
    {
        private int _alcoholPercent;

        public int AlcoholPercent
        {
            set
            {
                if (value >= 0 && value <= 100)
                    _alcoholPercent = value;
            }

            get => _alcoholPercent;
        }
    }
}
