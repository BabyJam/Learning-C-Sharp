using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayAtTheRaces
{
    class Players
    {
        private string identifier;
        public string Identifier
        {
            get
            {
                return identifier;
            }
            set
            {
                identifier = value;
            }
        }

        private int cash;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
            }
        }

    }
}
