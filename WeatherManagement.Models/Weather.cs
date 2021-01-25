using System;
using System.Collections.Generic;
using System.Text;

namespace WEManagement.Models
{
     public class Weather
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public decimal Temperature { get; set; }
        public int Humidity { get; set; }
    }
}
