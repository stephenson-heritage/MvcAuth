using System.Collections.Generic;

namespace MvcAuth.Models
{

    public class Product
    {
        public uint ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Stock> Inventory { get; set; }


    }

}