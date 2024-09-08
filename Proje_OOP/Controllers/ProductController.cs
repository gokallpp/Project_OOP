using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;
using System.Linq;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList(); // ToList ile ürün sınıfında yer alan değerleri getir. 
            return View(values);
        }



        [HttpGet] //
        public IActionResult AddProduct() 
        { 
            return View();
        }


        [HttpPost] // yükleme - gönderme işlemi
        public IActionResult AddProduct(Product p)
        {
            context.Add(p); //ekleme işlemleri yapıldı
            context.SaveChanges(); //değişiklikleri kaydetmek için kullanılır.
            return RedirectToAction("Index"); // sonra beni verilerin listelendiği ındex' e yönlendir.
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult UpdateProduct(int id) 
        {
            var value = context.Products.Where(x=>x.Id == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var value = context.Products.Where(x => x.Id == p.Id).FirstOrDefault();
            value.Name = p.Name;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
