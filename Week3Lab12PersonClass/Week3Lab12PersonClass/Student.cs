using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab12PersonClass
{
    class Student : Person
    {
        public Student (string name, string address, string track, int year, double fee) : base(name, address)
        {
            Track = track;
            Year = year;
            Fee = fee;
        }
        private string Track { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }
        public string GetTrack()
        {
            return Track;
        }
        public int GetYear()
        {
            return Year;
        }
        public double GetFee()
        {
            return Fee;
        }
        public override string ToString()
        {
            return $"Student[{base.ToString()}, track = {Track}, year = {Year}, fee = {Fee}]";
        }
    }
    
    
}
