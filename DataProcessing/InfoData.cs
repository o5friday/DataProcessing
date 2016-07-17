using System;

namespace DataProcessing
{
    struct InfoData: IChangeBoxedData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Change(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetField1()
        {
            return FirstName;
        }

        public string GetField2()
        {
            return LastName;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }
    }
}
