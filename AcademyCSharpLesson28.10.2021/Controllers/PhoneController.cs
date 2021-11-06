using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCproj.Context;
using MVCproj.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCproj.Controllers
{
    public class PhoneController : Controller
    {
        private readonly MVCContext _context;

        // GET: /<controller>/

        public PhoneController(MVCContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var result = await _context.Phones.ToListAsync();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Products phone, CancellationToken token)
        {
            if (!ModelState.IsValid)
            {
                return View(phone);
            }

            phone.TimeOfDelivery = DateTime.UtcNow;

            _context.Phones.Add(phone);

            await _context.SaveChangesAsync(token);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            if (phone == null)
            {
                return RedirectToAction("Index");
            }

            return View(phone);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            if (phone == null)
            {
                return RedirectToAction("Index");
            }
            _context.Phones.Remove(phone);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Products phoneModel)
        {
            if (!ModelState.IsValid)
            {
                return View(phoneModel);
            }

            var phone = await _context.Phones.FindAsync(phoneModel.Id);

            if (phoneModel == null)
            {
                return RedirectToAction("Index");
            }

            phone.Cost = phoneModel.Cost;
            phone.Product = phoneModel.Product;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
