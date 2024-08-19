using ElectraASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using Stripe.Issuing;
using static System.Net.WebRequestMethods;

namespace ElectraASP.Pages
{
    public class PaymentModel : PageModel
    {

        private readonly StripeSettings _stripeSettings;

        public string SessionId { get; set; }
        private readonly ThisContext _context;
        public List<Part> BoughtStuff { get; set; } = new List<Part>();
        public PaymentModel(IOptions<StripeSettings> stripeSettings, ThisContext context)
        {
            _stripeSettings = stripeSettings.Value;
            _context = context;

        }

        public void OnPost()
        {
            ViewData["ViewAlert"] = false;
            BoughtStuff.Insert(0, _context.ShoppingCart.Select(c=>c.Processor).ToList()[0]);
            BoughtStuff.Insert(1, _context.ShoppingCart.Select(c => c.ComputerCooler).ToList()[0]);
            BoughtStuff.Insert(2, _context.ShoppingCart.Select(c => c.ComputerCase).ToList()[0]);
            BoughtStuff.Insert(3, _context.ShoppingCart.Select(c => c.PC_Motherboard).ToList()[0]);
            BoughtStuff.Insert(4, _context.ShoppingCart.Select(c => c.PowerSupply).ToList()[0]);
            BoughtStuff.Insert(5, _context.ShoppingCart.Select(c => c.Memory).ToList()[0]);
            BoughtStuff.Insert(6, _context.ShoppingCart.Select(c => c.Storage).ToList()[0]);
            BoughtStuff.Insert(7, _context.ShoppingCart.Select(c => c.GraphicsCard).ToList()[0]);
        }

        public void OnGet()
        {
            ViewData["ViewAlert"] = false;
            BoughtStuff.Insert(0, _context.ShoppingCart.Select(c => c.Processor).ToList()[0]);
            BoughtStuff.Insert(1, _context.ShoppingCart.Select(c => c.ComputerCooler).ToList()[0]);
            BoughtStuff.Insert(2, _context.ShoppingCart.Select(c => c.ComputerCase).ToList()[0]);
            BoughtStuff.Insert(3, _context.ShoppingCart.Select(c => c.PC_Motherboard).ToList()[0]);
            BoughtStuff.Insert(4, _context.ShoppingCart.Select(c => c.PowerSupply).ToList()[0]);
            BoughtStuff.Insert(5, _context.ShoppingCart.Select(c => c.Memory).ToList()[0]);
            BoughtStuff.Insert(6, _context.ShoppingCart.Select(c => c.Storage).ToList()[0]);
            BoughtStuff.Insert(7, _context.ShoppingCart.Select(c => c.GraphicsCard).ToList()[0]);
        }

        public async Task<IActionResult> OnPostCreateCheckoutSessionAsync(string amount)
        {
            OnGet();
            var currency = "usd";

            var successUrl = "https://localhost:7025/";
            var cancelUrl = "https://localhost:7025/Shop";
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            var lineItems = new List<SessionLineItemOptions>();
            if (BoughtStuff == null)
            {
                ViewData["ViewAlert"] = true;
                return Redirect("/Shop");
            }
            else
            {
                foreach (var item in BoughtStuff)
                {
                    if (item == null) continue;
                    lineItems.Add(new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = currency,
                            UnitAmount = Convert.ToInt32(item.Price * 100),  // Amount in cents
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = item.Name
                            }
                        },
                        Quantity = 1
                    });
                }

                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string> { "card" },
                    LineItems = lineItems,
                    Mode = "payment",
                    SuccessUrl = successUrl,
                    CancelUrl = cancelUrl
                };

                var service = new SessionService();
                var session = await service.CreateAsync(options);
                return Redirect(session.Url);
            }
        }

        public void DeleteFromDB()
        {
            var shoppingCart = _context.ShoppingCart.FirstOrDefault();
            shoppingCart.ProcessorID = null;
            shoppingCart.CaseID = null;
            shoppingCart.MemoryID = null;
            shoppingCart.CoolerID = null;
            shoppingCart.GraphicsCardID = null;
            shoppingCart.StorageID = null;
            shoppingCart.MotherboardID = null;
            shoppingCart.PowerSupplyID = null;
            _context.SaveChanges();
        }


        public async Task<IActionResult> success()
        {
            DeleteFromDB();
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }

        public IActionResult cancel()
        {
            return RedirectToPage("/Index");
        }
    }
}