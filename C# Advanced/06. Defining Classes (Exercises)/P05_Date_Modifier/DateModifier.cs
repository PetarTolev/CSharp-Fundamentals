namespace P05_Date_Modifier
{
    using System;

    public class DateModifier
    {
        public DateTime FirstDate { get; set; }

        public DateTime SecondDate { get; set; }

        public DateModifier(DateTime firstDate, DateTime secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public int CalculateDifference()
        {
            return (int)Math.Abs((this.FirstDate - this.SecondDate).TotalDays);
        }
    }
}
