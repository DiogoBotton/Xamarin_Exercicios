using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsM1.Models
{
    public class Time
    {
        public static List<Time> times = new List<Time>();
        public string Nome { get; set; }
        public string Estadio{ get; set; }
        public string Img { get; set; }

        public Time()
        {

        }
    }
}
