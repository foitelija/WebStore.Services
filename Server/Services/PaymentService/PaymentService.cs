using BlazorShop.Shared;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;

namespace BlazorShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51L3dCeCVfTeuarsVrQo0DWNeu6Mrwon0xJPgQaO4Oc3H8IKwSbCReHJWRLyoLD3BNbL6boK2MHOQhinenGZ8EXEZ00T4RPwySU";
        }

        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(item => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions{
                    UnitAmountDecimal = item.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = item.ProductTitle,
                        Images = new List<string>
                        {
                            item.Image
                        }
                    }
                },
                Quantity = item.Quantity
            }));

            var options = new SessionCreateOptions()
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = lineItems,
                Mode = "payment",

                //SuccessUrl = "http://babidzhonych.herokuapp.com/order-success",
                //CancelUrl = "http://babidzhonych.herokuapp.com/cart",

                SuccessUrl = "https://localhost:44391/order-success",
                CancelUrl = "https://localhost:44391/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;

        }
    }
}
