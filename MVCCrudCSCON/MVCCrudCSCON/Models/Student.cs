using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrudCSCON.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}