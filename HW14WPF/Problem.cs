using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14WPF
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Image { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
