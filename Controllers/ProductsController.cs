using E_TicaretSitesi.Data;
using E_TicaretSitesi.Dto;
using E_TicaretSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using NuGet.Protocol.Plugins;

namespace E_TicaretSitesi.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductsController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Products> objProductList = _db.Products;
            return View(objProductList);
        }
        public IActionResult Accesories()
        {
            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult KidsWear()
        {

            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult MansWear()
        {

            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult WomansWear()
        {

            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult ShowAll()
        {
            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult AboutUs()
        {
            
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult LogInStore(LoginForm request)
        {
            bool varMı = _db.Set<Users>().Any(y => y.Email == request.Email && y.Password == request.Password);
            if (varMı == true)
            {
                return View("AboutUs");
            }
            else
            {
                return View("LogIn");
                
            }

        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUpStore(SignUpForm request)
        {
            if (request.Password == request.PasswordAgain)
            {
                
                var newUser = new Users { NameSurname = request.NameSurname, Email = request.Email, Password = request.Password };
                _db.Add(newUser);
                _db.SaveChanges();
                return View("LogIn");
            }
            else
            {

                return View("SignUp");
            }

        }
        public IActionResult Basket()
        {
            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult SearchProduct(SearchForm request)
        {
            bool varMı = _db.Set<Products>().Any(y => y.Name == request.searchingProduct);
            if (varMı == true)
            {
                return View("FindProduct");
            }
            else
            {
                return RedirectToAction();

            }

        }


    }
}
