using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoCleanCode.Entities;

namespace DemoCleanCode
{
    public class FormPersistance
    {
        public FormRow ObtainRow(string id)
        {
            return new FormRow();
        }
    }

    public class DetailPersistance
    {
        public DetailRow GetRow(string id)
        {
            return new DetailRow();
        }
    }
}
