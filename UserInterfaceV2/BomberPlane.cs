using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
    class BomberPlane
    {
        private string name;
        private int maxInventory;
        private int bombs;
        private double fuel;
        private double maxFuel;
        private Image picture;

      
        public string Name { get => name; set => name = value; }
        public int MaxInventory { get => maxInventory; set => maxInventory = value; }
        public int Bombs { get => bombs; set => bombs = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double MaxFuel { get => maxFuel; set => maxFuel = value; }
        public Image Picture { get => picture; set => picture = value; }

        public BomberPlane(string name, double maxFuel, int maxInventory,Image picture)
        {
            this.MaxFuel = maxFuel;
            this.Name = name;
            this.MaxInventory = maxInventory;
            this.Picture = picture;
        }

        
    }
}
