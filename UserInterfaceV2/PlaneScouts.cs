using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
    class PlaneScouts
    {
        private string name;
        private Image picture;
        private int fuelCapacity;

        
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }

        public PlaneScouts(Image picture, string name, int fuelCapacity)
        {
            this.Name = name;
            this.Picture = picture;
            this.FuelCapacity = fuelCapacity;
        }

        
    }
}
