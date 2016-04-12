using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mnx.Antlr.Data.Models
{

    public class RecurrencePattern﻿
    {
        public TimeSpan Time { get; set; }
        public int DayOfMonth { get; set; }
        public List<DayOfWeek> DaysOfWeek { get; set; }
        public int Month { get; set; }
        public DateTime? TargetDate { get; set; }
        public int Every { get; set; }
        public int Ordinal { get; set; }
        public QuartzIntervalUnit Period { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string ToCronExpression()
        {
            EndDate = null; //end dates not supported.   Don't allow them through
            var dayString = String.Empty;
            if (DayOfMonth > 0)
            {
                dayString = "Day " + DayOfMonth + " of ";
            }
            //var ordinalExpression = "";
            var every = String.Format("every {0} {1}s", Every, Period);
            var range = String.Empty;//Needed in lexer/parser? or pass in DTO
            //var range =EndDate.HasValue ? "from " + StartDate.ToString("yyyy-MM-dd hh:mm:ss tt") + " to " + EndDate : "starting " + StartDate.ToString("yyyy-MM-dd hh:mm:ss tt");
            var daysofweek = String.Empty;
            if (DaysOfWeek != null && Every > 0)
            {
                if (DaysOfWeek.Count == 1)
                {
                    daysofweek = DaysOfWeek[0].ToString();
                }
                else
                {
                    daysofweek = (Ordinal == 0 ? " on " : String.Empty) + String.Join(" and ", DaysOfWeek);
                }
            }
            if (Ordinal > 0)
            {
                if (DaysOfWeek != null && (DaysOfWeek.Contains(DayOfWeek.Saturday) && DaysOfWeek.Contains(DayOfWeek.Sunday)))
                {
                    daysofweek = "Weekend";
                }
                else if (DaysOfWeek != null && (DaysOfWeek.Count == 5 && !(DaysOfWeek.Contains(DayOfWeek.Saturday) && DaysOfWeek.Contains(DayOfWeek.Sunday))))
                {
                    daysofweek = "Weekday";
                }
                var month = String.Empty;
                if (Month > 0)
                {
                    month = CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(Month) + " ";
                }
                return String.Format("The {0} {1} of {2}{3}", GetOrdinal(Ordinal), daysofweek, month, every);
            }
            if (TargetDate.HasValue)
            {
                return String.Format("{0} {1} {2}", TargetDate.Value.ToString("MMMM"), GetDayWithOrdinalSuffix(TargetDate.Value.Day), every);
            }
            return String.Format("{0}{1}{2}{3}", dayString, every, range, daysofweek).Trim();
        }
        /// <summary>
        /// Convert instance to DSL string MD-1704
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            EndDate = null; //end dates not supported.   Don't allow them through
            var dayString = String.Empty; 
            if (DayOfMonth >0)
            {
                dayString = "Day " + DayOfMonth + " of ";
            }
            //var ordinalExpression = "";
            var every = String.Format("every {0} {1}s", Every, Period);
            var range = String.Empty;//Needed in lexer/parser? or pass in DTO
            //var range =EndDate.HasValue ? "from " + StartDate.ToString("yyyy-MM-dd hh:mm:ss tt") + " to " + EndDate : "starting " + StartDate.ToString("yyyy-MM-dd hh:mm:ss tt");
            var daysofweek = String.Empty;
            if (DaysOfWeek != null && Every  >0)
            {
                if (DaysOfWeek.Count == 1)
                {
                    daysofweek = DaysOfWeek[0].ToString();
                }
                else
                {
                    daysofweek = (Ordinal == 0 ? " on " : String.Empty) + String.Join( " and ", DaysOfWeek);
                }
            }
            if (Ordinal > 0)
            {
                if (DaysOfWeek != null && (DaysOfWeek.Contains(DayOfWeek.Saturday) && DaysOfWeek.Contains(DayOfWeek.Sunday)))
                {
                    daysofweek = "Weekend";
                }
                else if (DaysOfWeek != null && (DaysOfWeek.Count == 5 && !(DaysOfWeek.Contains(DayOfWeek.Saturday) && DaysOfWeek.Contains(DayOfWeek.Sunday))))
                {
                    daysofweek = "Weekday";
                }
                var month = String.Empty;
                if (Month > 0)
                {
                    month = CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(Month) + " ";
                }
                return String.Format("The {0} {1} of {2}{3}", GetOrdinal(Ordinal), daysofweek, month, every);
            }
            if (TargetDate.HasValue)
            {
                return String.Format("{0} {1} {2}", TargetDate.Value.ToString("MMMM"), GetDayWithOrdinalSuffix(TargetDate.Value.Day), every);
            }
            return String.Format("{0}{1}{2}{3}", dayString, every,  range, daysofweek).Trim();
        }

        private static string GetOrdinal(int num)
        {
            switch (num)
            {
                case 1:
                    return "first";
                case 2:
                    return "second";
                case 3:
                    return "third";
                case 4:
                    return "fourth";
                case 5:
                    return "fifth";
                case 6:
                    return "last";
                default:
                    return String.Empty;
            }
        }
        private static string GetDayWithOrdinalSuffix(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }

        }
    }
}
