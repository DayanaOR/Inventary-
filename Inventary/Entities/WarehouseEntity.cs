using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get;set; }

        [StringLength(100)]
        public string WarehouseAddress { get;set; }

        //Relacion con el almacenamiento (StorageEntity)
        public ICollection<StorageEntity> StorageEntities { get; set; }
    }
}
