using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OurMallWebApp.Models
{
    public class OrderModel : OurMallWebApp.Order
    {

        public decimal TotalPayment
        {
            get
            {
                return this.Order_Products.Sum(p => p.TotalSale);
            }
        }
    }
}