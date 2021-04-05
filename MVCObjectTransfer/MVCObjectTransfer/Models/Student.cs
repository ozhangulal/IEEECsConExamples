using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCObjectTransfer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //public override string ToString()
        //{
        //    return this.Name+" "+this.Surname+" "+this.Id;
        //}
    }
}