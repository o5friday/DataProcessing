using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing
{
    internal interface IChangeBoxedData
    {
        void Change(string field1, string field2);

        string GetField1();
        string GetField2();
    }
}
