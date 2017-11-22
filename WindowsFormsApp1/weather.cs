using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class weather
    {
        public int code;
        public string degree;
        public string traffic;
        public string weath;

        public weather(int code, string degree, string traffic, string weath)
        {

            this.code = code;
            this.degree = degree;
            this.traffic = traffic;
            this.weath = weath;

        }

        public int getcode()
        {
            return code;
        }

        public string getdegree()
        {
            return degree;
        }

        public string gettraffic()
        {
            return traffic;
        }
        public string getweath()
        {
            return weath;
        }
    }
}
