using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Category.ToList();
            }
        }
        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db= new InventaryContext())
            {
                db.Category.Add(oCategory);
                db.SaveChanges();
            }
        }
        public void updateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Update(oCategory);
                db.SaveChanges();
            }
        }
    }

}
  