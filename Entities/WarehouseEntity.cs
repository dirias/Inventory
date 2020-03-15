using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        public string WarehouseId { get; set; }
        [StringLength(20)]
        public string WarehouseName { get; set; }
        [StringLength(100)]
        public string WarehouseAddress { get; set; }
        //Relación con almacenamiento
        public ICollection<StorageEntity> storages { get; set; }
    }
}
