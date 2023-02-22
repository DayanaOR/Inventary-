using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using(var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using(var db = new InventaryContext())
            {
                db.Storage.Add(oStorage);
                db.SaveChanges();   
            }
        }
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Update(oStorage);
                db.SaveChanges();
            }
        }

    }
}
