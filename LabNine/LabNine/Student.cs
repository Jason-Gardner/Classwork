using System;
using System.Collections.Generic;
using System.Text;

namespace LabNine
{
    class Student
    {
        public string name { get; set; }
        public string city { get; set; }
        public string food { get; set; }
        public string band { get; set; }

        public Student(string sname, string scity, string sfood, string sband)
        {
            name = sname;
            city = scity;
            food = sfood;
            band = sband;
        }

        public Student()
        {

        }
    }
}
