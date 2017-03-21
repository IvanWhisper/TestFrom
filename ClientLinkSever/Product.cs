using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientLinkSever
{
    public class Product
    {
        public int Id { get; set; }
        public string pdid { get; set; }
        public string pdname { get; set; }
        public string pdcate { get; set; }
        public decimal Price { get; set; }
    }
}