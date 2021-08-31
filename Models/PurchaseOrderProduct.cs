using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class PurchaseOrderProduct
    {
        public int Id { get; set; }
        public int PurchaseOrderReceiptId { get; set; }

        public int ProductId { get; set; }

        public float UnitPrice { get; set; }

        public int Quantity { get; set; }

        public float Discount { get; set; }
        public float Tax { get; set; }

        public float Vat { get; set; }

        public Product Product { get; set; }

        public PurchaseOrderReceipt PurchaseOrderReceipt { get; set; }
    }
}
