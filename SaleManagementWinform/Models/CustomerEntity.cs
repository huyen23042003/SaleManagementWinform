using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SaleManagementWinform.Models
{

    public class CustomerEntity
    {
        
        [DisplayName("Mã khách hàng")]
        public string CustomerID { get; set; }

        [DisplayName("Tên khách hàng")]
        public string CustomerName { get; set; }

        [DisplayName("Số điện thoại")]
      
        public string Phone { get; set; }
    }
}