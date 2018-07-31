using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab12PersonClass
{
    class Staff : Person
    {
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }
        private string School { get; set; }
        private double Pay { get; set; }

        public string GetSchool()
        {
            return School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public override string ToString()
        {
            return $"Staff[{base.ToString()} , school = {School} , pay = {Pay}]";
        }
    }
    
    
}
