using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductStoreMVC.Context;
using ProductStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductStoreMVC.Controllers
{
    public class StoreController : Controller
    {
        //List<Store> stores = new List<Store>();

        private readonly MVCContext _context;

        public StoreController(MVCContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var result = await _context.Stores.ToListAsync(); 
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Store store, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return View(store);
            }

            store.DeliveryDate = DateTime.UtcNow;
            _context.Stores.Add(store);

            await _context.SaveChangesAsync(cancellationToken);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var store = await _context.Stores.FindAsync(id);
            if (store == null)
            {
                return RedirectToAction("Index");
            }

            return View(store);
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var store = await _context.Stores.FindAsync(id);
            if (store == null)
            {
                return RedirectToAction("Index");
            }

            _context.Stores.Remove(store);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Store storeProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(storeProduct);
            }

            var store = await _context.Stores.FindAsync(storeProduct.Id);
            if (storeProduct == null)
            {
                return RedirectToAction("Index");
            }

            store.Cost = storeProduct.Cost;
            store.Product = storeProduct.Product;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
