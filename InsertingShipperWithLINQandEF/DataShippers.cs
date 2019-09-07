using System.Collections.Generic;
using System.Linq;
using System;

namespace InsertingShipperWithLINQandEF
{
    public class DataShippers
    {
        private NorthwindEntities db = new NorthwindEntities();

        public List<Shipper> GetShippers()
        {
            return db.Shippers.ToList();
        }

        public int InsertShipper(Shipper shipper)
        {
            try
            {
                db.Shippers.Add(shipper);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR >> \n" + ex.ToString());
            }

            return shipper.ShipperID;
        }
    }
}
