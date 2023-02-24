using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        public string id;

        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]  
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Relacion con CategoryEntity
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Coleccion almacenamiento(StorageEntity)
        public ICollection<StorageEntity> Storage { get; set;}
    }
}
