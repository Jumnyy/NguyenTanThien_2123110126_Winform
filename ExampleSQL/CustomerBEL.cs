using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQL
{
    public class CustomerBEL
    {
        public int Id { get; set; } // Sửa id -> Id
        public string Name { get; set; } // Sửa name -> Name

        public string AreaName { get; set; } = ""; //
        public int IdArea { get; set; }

    }
}
