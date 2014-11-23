﻿using CrazyMelsWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyMelsWeb.Models
{
    public class Cart : CrazyMelDataModel
    {
        public Cart(C_Cart rawInput)
        {
            orderID = rawInput.orderID;
            prodID = rawInput.prodID;
            quantity = rawInput.quantity;
        }

        public Cart()
        {
            orderID = 0;
            prodID = 0;
            quantity = 0;
        }


        public int orderID { get; set; }
        public int prodID { get; set; }
        public int quantity { get; set; }
    }
}