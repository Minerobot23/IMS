using System;
using System.ComponentModel.DataAnnotations;

namespace Ims_api.Models
{
    public class InventoryItems
    {
        [Key]
        public int SKU {get; set; }
        public string Product_name {get; set; }
        public int Product_quantity {get; set; }
        public float Price {get; set; }
        public DateTime Last_update {get; set; } 

    }

}