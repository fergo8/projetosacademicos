using System;

namespace ElementsComposition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        private double ValuePerHour { get; set; }
        private int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
