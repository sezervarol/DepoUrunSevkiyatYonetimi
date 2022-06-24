using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarBal.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public string ShipmentName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool Delete { get; set; }
        public bool View { get; set; }
        public List<Order> Order { get; set; }
    }
}