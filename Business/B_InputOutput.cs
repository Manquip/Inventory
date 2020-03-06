using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> OutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }
        
        public static void CreateOutput(InputOutputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateOutput(InputOutputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oOutput);
                db.SaveChanges();
            }
        }
    }
}
