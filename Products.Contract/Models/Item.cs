using System;
namespace Products.Contract.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }

        public Item()
        {
        }
    }
}
