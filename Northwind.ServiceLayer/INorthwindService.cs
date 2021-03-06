using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ServiceLayer
{
    [ServiceContract]
    public interface INorthwindService
    {
        [OperationContract]
        List<Shipper> GetShippers();
    }
}
