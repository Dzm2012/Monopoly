using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Server
{
    enum playerPeice{
        Dog,
        Tophat,
        Thimble,
        Iron,
        Shoe,
        Battleship,  
        Cannon
    }
    class Player
    {
        public playerPeice Character = playerPeice.Dog;
        public string UserName = "";
        public int Money = 0;
        public bool GetOutFree = false;
        public List<Prop> proporties = new List<Prop>();

        public Player(playerPeice character, string userName, int money)
        {
            Character = character;
            UserName = userName;
            Money = money;
        }

        public void AddProp(Prop prop)
        {
            proporties.Add(prop);
        }

        public void RemoveProp(Prop prop)
        {
            proporties.Remove(prop);
        }
    }
}
