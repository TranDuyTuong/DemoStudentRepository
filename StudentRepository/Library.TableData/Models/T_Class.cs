using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TableData.Models
{
    public class T_Class
    {
        public int IDClass { get; set; }
        public string NameClass { get; set; }
        public List<T_Student> T_Student { get; set; }
    }
}
