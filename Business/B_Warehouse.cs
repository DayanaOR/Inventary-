using Azure.Core;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WareHouseList()
        {
            using(var bd = new InventaryContext())
            {
                return bd.Warehouse.ToList();
            }
        }

        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using(var bd = new InventaryContext())
            {
                bd.Warehouse.Add(oWarehouse);
                bd.SaveChanges();
            }
        }
        public static void UpdateWareHouse(WarehouseEntity oWareHouse)
        {
            using(var bd = new InventaryContext()) 
            {
                bd.Warehouse.Update(oWareHouse);
                bd.SaveChanges();   
            }
        }
    }
}
