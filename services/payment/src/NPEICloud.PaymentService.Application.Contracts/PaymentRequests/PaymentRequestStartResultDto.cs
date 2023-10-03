using System;

namespace NPEICloud.PaymentService.PaymentRequests;

[Serializable]
public class PaymentRequestStartResultDto
{
    public string CheckoutLink { get; set; }
}