using System;
using System.Collections.Generic;
using System.Text;

namespace ElementsComposition.Entities
{
    class HourContract
    {
        private DateTime Date { get; set; }
        private Double ValuePerHour { get; set; }
        private int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, Double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public Double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
