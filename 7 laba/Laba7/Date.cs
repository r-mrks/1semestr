using System;

namespace Laba7
{
    public struct Date
    {
        private int day;
        private int month;
        private int year;
        
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            
        }
        public string GetWeekDay()
        {
            int days = day;
            if (year > 1) {
                 days += year * 365;       
            }
            if (month > 1) {
                days += month * 30;
            } 
            int daysWeek = days % 7;
            if (daysWeek == 1) return "Понедельник"; 
            if (daysWeek == 2) return "Вторник"; 
            if (daysWeek == 3) return "Среда"; 
            if (daysWeek == 4) return "Четверг"; 
            if (daysWeek == 5) return "Пятница"; 
            if (daysWeek == 6) return "Суббота";
            return "Воскресенье";
            Console.WriteLine(GetWeekDay());

        }
    }
}