using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
    class Player
    {
        private string userName;
        private string password;
        private string startTime;
        private string endTime;
        
        public string UserName {get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
       

        public Player(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }


        public Player(string startTime,string userName,string endTime)
        {
            this.startTime = startTime;
            this.UserName = userName;
            this.endTime = endTime;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", UserName, Password);
        }
    }
}
