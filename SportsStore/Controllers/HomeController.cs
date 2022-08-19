using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository storeRepository;

        public int PageSize = 4;
        public HomeController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        public ViewResult Index(int productPage = 1) => View(new ProductsListViewModel
 {
            Products = storeRepository.Products
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),
     
            PagingInfo = new PagingInfo
     {
         CurrentPage = productPage,
         ItemsPerPage = PageSize,
         TotalItems = storeRepository.Products.Count()
     }
 });
        //public ViewResult Index(int productPage = 1)=> View(storeRepository
        //    .Products.OrderBy(p => p.ProductID)
        //    .Skip((productPage - 1) * PageSize)
        //    .Take(PageSize));

        //public IActionResult Index() => View(storeRepository.Products);
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
