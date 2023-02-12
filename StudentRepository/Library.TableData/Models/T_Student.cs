using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TableData.Models
{
    public class T_Student
    {
        public int IDStudent { get; set; }
        public string NameStudent { get; set; }
        public int IDClassStudent { get; set; }
        public T_Class T_Class { get; set; }
    }
}
