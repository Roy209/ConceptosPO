namespace ConceptosPO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month,int day)
        {
            _year = year;
            _month = checkMonth(month);
            _day = checkDay(day,month,year);
        }

        private int checkDay(int day,int mounth, int year)
        {
            if(mounth == 2 && day == 29 && isLeapYear(year))return day;
            int[] daysMounth = { 0,31,28,31,30,31,30,31,31,30,31,30,31};
            if (day > 0 && day <= daysMounth[mounth]) return day;
            throw new dayException("invalid Day");
        }

        private bool isLeapYear(int year)
        { 
            return year % 400 == 0  || year % 4 == 0 && year % 100 !=0;
            //if(year %  4 ==0){
            //    if(year % 100 == 0)
            //    {
            //        if(year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
            
            throw new dayException("invalid Day");
        }

        private int checkMonth(int month)
        {
            if (month >= 1 && month <= 12) return month;
            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
