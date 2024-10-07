using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprintverseny
{
    internal class Sprint
    {
        public Dictionary<string, TimeSpan> times = new Dictionary<string, TimeSpan>();
        public string Name { get; set; }
        public int BirthDate { get; set; }
        public int StartNumber { get; set; }
        public string Sex { get; set; }
        public string Kateg { get; set; }
        public int Age => (int)(DateTime.Now.Year - BirthDate);
        public Sprint(string row)
        {
            var v = row.Split(';');
            Name = v[0];
            BirthDate = int.Parse(v[1]);
            StartNumber= int.Parse(v[2]);
            Sex = v[3];
            Kateg = v[4];
            times.Add("SwimTime", TimeSpan.Parse(v[5]));
            times.Add("FirstDepo", TimeSpan.Parse(v[5]));
            times.Add("BikeTime", TimeSpan.Parse(v[7]));
            times.Add("SecondDepo", TimeSpan.Parse(v[8]));
            times.Add("RunTime", TimeSpan.Parse(v[9]));
        }
    }
}

