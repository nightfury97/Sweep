using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweepCake.Models
{
    public class banh
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public static IEnumerable<banh> GetList(int soluong)
        {
            var st = new List<banh>();
            for (int i=1;i<=soluong;i++)
            {
                st.Add(new banh { ID = i, Name = "Bánh socola " + i.ToString(), Price = 10 });

            }
            return st;
        }
    }
}