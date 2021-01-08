using DrinKing.Data.Interfaces;
using DrinKing.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinKing.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        [Authorize]  //Sadece Giriş yapan kullanıcılar sepeti görebilecek
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost] //hep post çevirdiğimiz için forma yapılan tanımlama
        [Authorize]  //Sadece Giriş yapan kullanıcılar alışveriş yapabilecek
        //kullanıcı girişi yapmayan biri Order/Checkout bağlantısına dahi gitse o ekranı göremeyecek login ekranı ile karşılaşacak
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Sepet boş görünüyor, lütfen sepete ürün ekleyin");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Siparişiniz için teşekkürler";
            return View();
        }
    }
}
