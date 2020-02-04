using System;
using System.Collections.Generic;
using System.Text;

namespace rokomari.com
{
    class Order
    {
        public string _prName;
        public int _quantity;
        public int _price;
        public int _deliveryCharge;
        public int _totalPrice;
        public Order(string prName,int quantity,int price,int deliveryCharge)
        {
            _prName = prName;
            _quantity = quantity;
            _price = price;
            _deliveryCharge = deliveryCharge;
            _totalPrice = _price + _deliveryCharge;
        }
        public override string ToString()
        {
            var print = $"Product Name:{_prName}\nQuantity:{_quantity}\nPrice:{_price}\nDelivery Charge:{_deliveryCharge}\nTotal Price:{_totalPrice}";
            return print;
        }
    }
}
