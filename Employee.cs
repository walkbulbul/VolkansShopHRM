using BethanysPieShopHRM.HR;
using System;

namespace VolkansPieShopHRM
{
    internal class Employee
    {
        public Employee(string v1, string v2, string v3, DateTime dateTime, EmployeeType manager, object p)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            DateTime = dateTime;
            Manager = manager;
            P = p;
        }

        public string FirstName { get; internal set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public DateTime DateTime { get; }
        public EmployeeType Manager { get; }
        public object P { get; }
        public string LastName { get; internal set; }
    }
}