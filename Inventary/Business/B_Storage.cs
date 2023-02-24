
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public static void CreateStorage (StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(oStorage);
                db.SaveChanges();
      
            }
        }
        public static bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storage.ToList()
                    .Where(p => p.StorageId == idStorage);

                var x = product.Any();
                return x;
            }
        }

        public static List<StorageEntity> StorageProductsByWareHouse(string idWareHouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storage
                    .Include(s=>s.Product)
                    .Include(s=>s.WareHouse)
                    .Where(s=>s.WareHousesId == idWareHouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            oStorage.LastUpDate = DateTime.Now;

            using (var db = new InventaryContext())
            {
                db.Storage.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}