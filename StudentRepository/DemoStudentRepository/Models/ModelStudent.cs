using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStudentRepository.Models
{
    public class ModelStudent
    {
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public string NameClass { get; set; }
        public int IdClass { get; set; }
    }
}
