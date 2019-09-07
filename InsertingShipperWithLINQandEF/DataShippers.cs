using System.Collections.Generic;
using System.Linq;

namespace InsertingShipperWithLINQandEF
{
    public class DataShippers
    {
        private NorthwindEntities db = new NorthwindEntities();

        public List<Shipper> GetShippers()
        {
            return db.Shippers.ToList();
        }
    }
}
