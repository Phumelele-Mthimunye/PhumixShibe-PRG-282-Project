using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
    public class EnemyBaseObj
    {
        private int iD;
        private string name;
        private int points;
        private Image pictures;
        private bool targeted;
        private int location;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }
        public Image Pictures { get => pictures; set => pictures = value; }
        public bool Targeted { get => targeted; set => targeted = value; }
        public int Location { get => location; set => location = value; }

        public EnemyBaseObj(int iD,string name, int points, Image pictures)
        {
            this.ID = iD;
            this.Name = name;
            this.Points = points;
            this.Pictures = pictures;
        }

        public EnemyBaseObj()
        {
        }
    }
}
