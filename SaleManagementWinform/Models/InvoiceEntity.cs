using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SaleManagementWinform.Models
{
    public class InvoiceEntity
    {
        public string InvoiceID { get; set; }

        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        public decimal TotalPrice { get; set; }

        public List<InvoiceDetailEntity> InvoiceDetails { get; set; } = new List<InvoiceDetailEntity>();

        public InvoiceEntity()
        {
            InvoiceDetails = new List<InvoiceDetailEntity>();
        }
    }
}