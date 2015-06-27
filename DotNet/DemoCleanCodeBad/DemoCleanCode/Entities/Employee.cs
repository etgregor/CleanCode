﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanCode.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

        public bool IsOutsourcing { get; set; }

        PostalAdrees Adress { get; set; }
    }
}
