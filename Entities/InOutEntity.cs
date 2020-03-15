using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        public string InOutId { get; set; }
        public string InOutDate { get; set; }
        public int InOutQuantity { get; set; }
        public bool IsInput { get; set; }
        //Relación con almacenamiento
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }

    }
}
