using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
   public class MapObj
    {
        private string name;
        private Point coordinates;
        private double length;
        private double height;
        private string type;
        private Image images;
       
        public string Name { get => name; set => name = value; }
        public Point Coordinates { get => coordinates; set => coordinates = value; }
        public double Length { get => length; set => length = value; }
        public double Height { get => height; set => height = value; }
        public string Type { get => type; set => type = value; }
        public Image Images { get => images; set => images = value; }

        public MapObj(string name, Point coordinates, double length, double height,string type,Image images)
        {
            this.Name = name;
            this.Coordinates = coordinates;
            this.Length = length;
            this.Height = height;
            this.Type = type;
            this.Images = images; 
        }

      

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", Name, Coordinates, Length, Height, Type);
        }
    }
}
