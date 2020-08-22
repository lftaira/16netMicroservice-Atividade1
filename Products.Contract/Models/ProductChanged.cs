using System;
namespace Products.Contract.Models
{
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }

        public ProductChanged()
        {
        }
    }
}
