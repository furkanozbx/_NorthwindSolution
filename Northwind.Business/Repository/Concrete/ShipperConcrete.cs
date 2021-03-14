using Northwind.Business.Repository.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Repository.Concrete
{
    public class ShipperConcrete : IShipperRepository
    {
        public void Add(Shipper entity)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                db.Shippers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var s = db.Shippers.Find(id);
                db.Shippers.Remove(s);
                db.SaveChanges();
            }
        }

        public void Delete(Shipper entity)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                db.Shippers.Attach(entity);
                db.Entry<Shipper>(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Shipper entity)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                db.Shippers.Attach(entity);
                db.Entry<Shipper>(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Shipper> Get()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                return db.Shippers.ToList();
            }
        }

        public Shipper Get(int id)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                return db.Shippers.Find(id);
            }
        }
    }
}
