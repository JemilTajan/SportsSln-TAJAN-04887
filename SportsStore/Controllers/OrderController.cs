using Microsoft.AspNetCore.Mvc;
using SportsStore.Controllers;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
