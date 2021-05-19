using System;
using System.ComponentModel.DataAnnotations;

namespace joyceysgifts.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Design { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Display(Name = "Paid")]
        public string PayStatus { get; set; }
        [Display(Name = "Invoice Sent")]
        public string InvoiceSent { get; set; }

        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
    }
}