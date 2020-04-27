using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreApp
{

    public class test
    {
        void Test()
        {
            Invoice myInvoice = new Invoice { Email = "", MobileNo = "", OrderInformation = "" };

            EmailNotification _email = new EmailNotification();
            _email.SendMessage(myInvoice);
        }
    }
}


namespace RetailStoreApp
{
    public interface IMessage
    {
        void SendMessage(Invoice obj);
    }


    class Invoice
    {
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public OrderInformation OrderInformation { get; set; }
    }

    class OrderInformation
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }


    class OrderItems
    {
        public int ProductId { get; set; }
        public string ProductSKU { get; set; }
        public decimal Rate { get; set; }
        public decimal Tax { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Value { get; set; }
    }

    public class EmailNotification : IMessage
    {
        public void SendMessage(Invoice obj)
        {
            //Send mail
        }
    }


}