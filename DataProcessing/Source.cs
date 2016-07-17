using System.Collections.Generic;

namespace DataProcessing
{
    class Source
    {
        internal void CheckAndProceed(List<IChangeBoxedData> data)
        {
            var dest = new Destination();

            //do something

            dest.ProceedData(data);
        }
    }
}
