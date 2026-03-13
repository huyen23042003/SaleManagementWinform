using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SaleManagementWinform.Models
{
    public class ProductEntity
    {
        [DisplayName("Mã sản phẩm")]
        public string ProductID { get; set; }

        [DisplayName("Tên sản phẩm")]

        public string ProductName { get; set; }

        [DisplayName("Giá sản phẩm")]
        public decimal Price { get; set; }


    }
}