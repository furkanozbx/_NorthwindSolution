using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Repository.Concrete;
using Northwind.Entities;

namespace Northwind.ServiceLayer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class NorthwindService : INorthwindService
    {

        ShipperConcrete shipper = new ShipperConcrete();

        public List<Shipper> GetShippers()
        {
            return shipper.Get();
        }
    }
}
