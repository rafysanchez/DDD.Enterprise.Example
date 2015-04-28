﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Library.Command;

namespace Demo.Domain.Accounting.PaymentOrder.Commands
{
    public class ChangeEffective : DemoCommand
    {
        public Guid PaymentOrderId { get; set; }

        public DateTime Effective { get; set; }
    }
}