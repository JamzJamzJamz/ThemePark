﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemePark.ViewModels
{
    public class AdmissionsVM
    {
        [Display(Name = "Total Admissions for the Day")]
        public int DailyTotal { get; set; }

        [Display(Name = "Total Admissions for the Week")]
        public int WeeklyTotal { get; set; }

        [Display(Name = "Average Daily Asmissions for the Week")]
        public int WeeklyAvg { get; set; }

        [Display(Name = "Total Admissions for the Month")]
        public int MonthlyTotal { get; set; }

        [Display(Name = "Average Daily Admissions for the Month")]
        public int MonthlyAvg { get; set; }

        [Display(Name = "Total Admissions for the Year")]
        public int YearlyTotal { get; set; }

        [Display(Name = "Average Daily Adimssions for the Year")]
        public int YearlyAvg { get; set; }

        /* 
        public IEnumerable<SelectListItem> Months
        {
            get
            {
                return DateTimeFormatInfo
                .InvariantInfo
                .MonthNames
                .Select((monthName, Index) => new SelectListItem
                {
                    Value = (Index + 1).ToString(),
                    Text = monthName
                });
            }
        }
        */
    }
}