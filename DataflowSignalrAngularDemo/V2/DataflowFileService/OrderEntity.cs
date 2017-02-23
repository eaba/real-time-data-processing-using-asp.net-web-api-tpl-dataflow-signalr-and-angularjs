﻿using System;
using System.Collections.Generic;

namespace DataflowFileService
{
    public class OrderEntity
    {
        public Guid OrderID { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public Guid AccountNumber { get; set; }

        public Guid SalesPersonId { get; set; }
    }
}