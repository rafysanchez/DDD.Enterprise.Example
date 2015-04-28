﻿using FluentValidation;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Accounting.PaymentOrder.Entities.Invoice.Validators
{
    public class ChangeDiscount : AbstractValidator<Commands.ChangeDiscount>
    {
        public Guid PaymentOrderId { get; set; }

        public Guid InvoiceId { get; set; }

        public Decimal? Discount { get; set; }
    }
}