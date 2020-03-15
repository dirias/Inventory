using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        //Relacíon con productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //Relación con bodegas
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }
        public ICollection<InOutEntity> InputOutputs { get; set; }

    }
}
