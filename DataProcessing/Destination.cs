using System.Collections.Generic;

namespace DataProcessing
{
    class Destination
    {
        internal void ProceedData(List<IChangeBoxedData> data)
        {
            foreach (var item in data)
            {
                //do something
                item.Change($"{item.GetField1()} processed", $"{item.GetField2()} processed");
            }
        }
    }
}
