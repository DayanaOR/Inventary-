using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {

        public static List<InputOutputEntity> InOutputlist()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInOutput(InputOutputEntity oInOutput)
        {
            using(var db = new InventaryContext())
            { 
                db.InOuts.Add(oInOutput);
                db.SaveChanges();
            }
        }

        public static void updateInOutput(InputOutputEntity oInOutput) 
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Update(oInOutput);
                db.SaveChanges();
            }
        }
    }
}
