﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExpencesRepository
    {
        public static void addExpence(Expence expence)
        {
            using (var context = new DatabaseEntities())
            {
                context.Expences.Add(expence);
                context.SaveChanges();
            }
        }

        public static string GetExpence(int id)
        {
            using (var db = new DatabaseEntities())
            {
               return db.Expences.FirstOrDefault(x => x.expenceID == id).type;
            }
        }
        public static void deleteExpence(Expence expence)
        {
            using (var context = new DatabaseEntities())
            {
                Expence e = context.Expences.FirstOrDefault(x => x.expenceID == expence.expenceID);
                context.Expences.Remove(e);
                context.SaveChanges();
            }
        }

        public static void deleteExpence(int expenceID)
        {
            using (var context = new DatabaseEntities())
            {
                Expence e = context.Expences.FirstOrDefault(x => x.expenceID == expenceID);
                context.Expences.Remove(e);
                context.SaveChanges();
            }
        }

        public static List<Expence> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                return context.Expences.Select(x=> x).ToList();
            }
        }

    }
}
