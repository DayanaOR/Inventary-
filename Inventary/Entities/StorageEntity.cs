using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpDate { get; set; }

        [Required]  
        public int PartialQuantity { get; set; }
        
        //Relacion con los productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relacion con las Bodegas 
        public string WareHousesId { get; set; }
        public WarehouseEntity WareHouse { get; set; }    

        //Relacion con las entradas y las salidas 
        public ICollection<InputOutputEntity> InputOutputs { get; set;}
    }
}
