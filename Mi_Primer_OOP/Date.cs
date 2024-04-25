namespace Mi_Primer_OOP
{
    public class Date
    {
        //Properties
        public int Day {  get; set; } //getters and setters
        public int Month { get; set; }
        public int Year { get; set; }

        //Methods
        public Date(int day, int month, int year) //day=5, month= 12, year=2024
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string ShowDate()
        {
            var date = String.Format("{0}/{1}/{2}", Day, Month, Year);
            return date;
        }
    }
}
