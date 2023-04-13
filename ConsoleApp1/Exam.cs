using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam
    {
        public string Studentname
        {
            get { return Studentname; }
            set
            {
                if (value.Length > 3)
                    Studentname=value;
            }
        }
        public string Subject
        {
            get { return Subject; }
            set
            {
                if (value.Length > 3)
                    Subject=value;
            }
        }
        public int Point
        {
            get { return Point; }
            set
            {
                if (value >= 0 && value<=100) 
                    Point=value;
            }
        }
        public DateTime Startdata 
        {
            get;
            set;
           
        }
        public DateTime Enddata
        {
            get;
            set;
        }
        public int Duration
        {
            get; set;
        }

    }
}
