using BlazorShop.Shared;
using Stripe.Checkout;
using System.Collections.Generic;

namespace BlazorShop.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
