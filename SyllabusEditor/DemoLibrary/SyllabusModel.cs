using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SyllabusModel
    {
        public int Id { get; set; }
        public string Faculty { get; set; }
        public string Code { get; set; }

        public string FullName
        {
            get
            {
                return $"{ Faculty } { Code }";
            }
        }
    }
}
