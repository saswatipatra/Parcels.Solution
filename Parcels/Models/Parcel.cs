using System.Collections.Generic;

namespace Shipping.Models
{
    public class Parcel
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
       
        private static List<Parcel> _instances = new List<Parcel> {};

        public Parcel (int length, int weight, int width, int height)
        {
            Length = length;
            Weight = weight;
           Width= width;
           Height= height;
            _instances.Add(this);
        }
        
        public static List<Parcel> Volume()
        {
            return (Length*Height*Width);
        }

        public static List<Parcel> CostToShip()
        {
            int cost= Volume()/60;
            return cost;
        }

        public static List<Parcel> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}