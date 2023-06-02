using Lab3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Globalization;

namespace Lab3.ViewModels
{
    public class CourseViewModel
    {   
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            //string dateTimeString = $"{Date} {Time}";
            //return DateTime.ParseExact(dateTimeString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}
