using DaRT.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaRT
{
    public class Player
    {
        public int number;
        public String ip;
        public String ping;
        public String guid;
        public String name;
        public String status;
        public String lastseen;
        public String lastseenon;
        public String location;
        public String comment;
        public string uid;
        public Player(int number, String ip, String ping, String guid, String name, String status)
        {
            this.number = number;
            this.ip = ip;
            this.ping = ping;
            this.guid = guid;
            this.name = name;
            this.status = status;
            this.uid = WebClientAsd.GetUID(guid);

        }
        public Player(int number, String ip, String ping, String guid, String name, String status, String lastseen, String lastseenon, String location, string uid)
        {
            this.number = number;
            this.ip = ip;
            this.ping = ping;
            this.guid = guid;
            this.name = name;
            this.status = status;
            this.lastseen = lastseen;
            this.lastseenon = lastseenon;
            this.location = location;
            this.uid = uid;
        }

        public Player(int number, String ip, String lastseen, String guid, String name, String lastseenon, String comment, bool doComment,string uid = null)
        {
            this.number = number;
            this.ip = ip;
            this.guid = guid;
            this.name = name;
            this.lastseen = lastseen;
            this.lastseenon = lastseenon;
            this.comment = comment;
            this.uid = uid;
        }
    }
}
