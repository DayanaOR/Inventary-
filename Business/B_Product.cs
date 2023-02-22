﻿using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Net.NetworkInformation;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using(var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();   
            }
        }

    }
}