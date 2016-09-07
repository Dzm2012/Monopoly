using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Server
{
    class Prop
    {
        public string Name = "";
        public int Cost = 0;
        public int Rent = 0;
        public int RentH1 = 0;
        public int RentH2 = 0;
        public int RentH3 = 0;
        public int RentH4 = 0;
        public int RentHotel = 0;
        public int Mortage = 0;

        public Prop(string name, int cost, int rent, int rentH1, int rentH2, int rentH3, int rentH4, int rentHotel, int mortage)
        {
            Name = name;
            Cost = cost;
            Rent = rent;
            RentH1 = rentH1;
            RentH2 = rentH2;
            RentH3 = rentH3;
            RentH4 = rentH4;
            RentHotel = rentHotel;
            Mortage = mortage;
        }
    }
}
