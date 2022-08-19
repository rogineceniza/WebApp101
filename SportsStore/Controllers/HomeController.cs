using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository storeRepository;

        public HomeController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        public IActionResult Index() => View(storeRepository.Products);
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
