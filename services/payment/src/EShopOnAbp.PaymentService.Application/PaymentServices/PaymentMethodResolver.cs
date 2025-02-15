﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Volo.Abp.DependencyInjection;

namespace EShopOnAbp.PaymentService.PaymentServices;

public class PaymentMethodResolver : ITransientDependency
{
    private readonly IEnumerable<IPaymentMethod> _paymentMethods;
    private readonly ILogger<PaymentMethodResolver> _logger;

    public PaymentMethodResolver(IEnumerable<IPaymentMethod> paymentMethods, ILogger<PaymentMethodResolver> logger)
    {
        _paymentMethods = paymentMethods;
        _logger = logger;
    }

    public IPaymentMethod Resolve(int paymentTypeId)
    {
        IPaymentMethod paymentMethod = _paymentMethods.FirstOrDefault(q => q.PaymentTypeId == paymentTypeId);
        if (paymentMethod == null)
        {
            _logger.LogError($"Couldn't find Payment method with id:{paymentTypeId}");
            throw new ArgumentException("Payment method not found", paymentTypeId.ToString());
        }

        return paymentMethod;
    }
}