using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductStoreMVC.Context;
using ProductStoreMVC.Models;
using ProductStoreMVC.Models.ViewModels;
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

        public async Task<IActionResult> IndexAsync(int companyId = 0)
        {
            var result = _context.Stores.AsQueryable();

            if (companyId > 0) result = result.Where(p => p.StoreCompanyId == companyId).AsQueryable();
            var storeList = new List<StoreViewModel>();

            foreach (var store in await result.ToListAsync())
            {
                storeList.Add(new StoreViewModel
                {
                    Id = store.Id,
                    Product = store.Product,
                    Cost = store.Cost,
                    DeliveryDate = store.DeliveryDate,
                    StoreCompanyId = store.StoreCompanyId,
                    StoreCompanyName = store.StoreCompany.Name
                });
            }

            return View(storeList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var store = new StoreViewModel
            {
                Companies = await _context
                .StoreCompanies
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync()
            };
            return View(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StoreViewModel store, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                store.Companies = await _context.StoreCompanies.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync();
                return View(store);
            }

            var storeDb = new Store
            {
                Cost = store.Cost,
                Product = store.Product,
                StoreCompanyId = store.StoreCompanyId,
                DeliveryDate = DateTime.UtcNow,
            };

            store.DeliveryDate = DateTime.UtcNow;
            _context.Stores.Add(storeDb);

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

            var result = new StoreViewModel
            {
                Id = store.Id,
                Product = store.Product,
                Cost = store.Cost,
                StoreCompanyId = store.StoreCompanyId,
                Companies = await _context.StoreCompanies.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync()
            };

            return View(result);
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
        public async Task<IActionResult> Edit(StoreViewModel storeProduct)
        {
            if (!ModelState.IsValid)
            {
                storeProduct.Companies = await _context.StoreCompanies.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync();
                return View(storeProduct);
            }

            var store = await _context.Stores.FindAsync(storeProduct.Id);
            if (storeProduct == null)
            {
                return RedirectToAction("Index");
            }

            store.Cost = storeProduct.Cost;
            store.Product = storeProduct.Product;
            store.StoreCompanyId = storeProduct.StoreCompanyId;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
