using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses.moodle
{
    public class course
    {
        
        public int id {  get; set; }
        public string name { get; set; }
         public double courseshours { get; set; }
    }
}
