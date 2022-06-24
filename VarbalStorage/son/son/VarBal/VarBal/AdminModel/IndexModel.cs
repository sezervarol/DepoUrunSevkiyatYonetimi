using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VarBal.Models;

namespace VarBal.AdminModel
{
    public class IndexModel
    {
        public List<User> User { get; set; }
        public List<Permission> Permission { get; set; }
        public List<Shipment> Shipment { get; set; }
        public List<Contact> Contact { get; set; }
        public List<ContactUs> ContactUs { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Warehouse> Warehous { get; set; }
        public List<Product> Product { get; set; }
        public int ProductCount  { get; set; }
        public int ProductCountTrue  { get; set; }
        public int VehiclesCount { get; set; }
        public int VehiclesCountTrue { get; set; }
        public int UserTotalCount { get; set; }
        public int UserActiveCount { get; set; }
        public int UserPasiveCount { get; set; }
    }
}