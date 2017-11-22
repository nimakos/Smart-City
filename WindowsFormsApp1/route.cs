using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class route
    {
       
        public string media;
        public string place;
        public string route1;
        public string time_arr;
        public string parking;
        public string time_begin;
        public string cafe;

        public route(string media, string place, string route1, string time_arr, string parking , string time_begin, string cafe)
        {           
            this.media = media;
            this.place = place;
            this.route1 = route1;
            this.time_arr = time_arr;
            this.parking = parking;
            this.time_begin = time_begin;
            this.cafe = cafe;
        }

        public string getmedia()
        {
            return media;
        }

        public string getplace()
        {
            return place;
        }

        public string getroute()
        {
            return route1;
        }
        public string gettime_arr()
        {
            return time_arr;
        }
        public string getparking()
        {
            return parking;
        }
        public string gettime_begin()
        {
            return time_begin;
        }
        public string getcafe()
        {
            return cafe;
        }


    }
}
