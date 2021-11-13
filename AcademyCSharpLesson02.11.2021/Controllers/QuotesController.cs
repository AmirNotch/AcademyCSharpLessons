using AcademyCSharpLesson02._11._2021.Context;
using AcademyCSharpLesson02._11._2021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCSharpLesson02._11._2021.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {

        private readonly APIContext _context;

        public APIContext db;
        public QuotesController(APIContext context)
        {
            db = context;
            if (db.QuotesModels.Any())
            {
               /* db.QuotesModels.Add(new QuotesModel { Text = "Нет ничего более раздражающего, чем хороший пример.", Author = "Тома Сойера", InsertDate = DateTime.UtcNow, QuotesCategoryId = 3 });
                db.QuotesModels.Add(new QuotesModel { Text = "Прощение — это аромат, который фиалка дарит тому, кто её растоптал.", Author = "Эрнест Хемингуэй", InsertDate = DateTime.UtcNow, QuotesCategoryId = 4});
                db.QuotesModels.Add(new QuotesModel { Text = "Существуют три вида лжи: ложь, наглая ложь и статистика.", Author = "Марка Твена", InsertDate = DateTime.UtcNow, QuotesCategoryId = 5 });
                db.SaveChanges();*/
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuotesModel>>> Get()
        {
            return await db.QuotesModels.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<QuotesModel>> Post(QuotesModel quote)
        {
            if (quote == null)
            {
                return BadRequest();
            }
            if (quote.Author == "admin")
            {
                ModelState.AddModelError("Author", "Недопустимое имя Автора - admin");
            }
            // если есть ошибки - возвращаем ошибку 400
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            quote.InsertDate = DateTime.UtcNow;

            db.QuotesModels.Add(quote);
            await db.SaveChangesAsync();
            return Ok(quote);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<QuotesModel>> Put([FromRoute] string id,[FromBody]QuotesModel quote)
        {
            if (quote == null)
            {
                return BadRequest();
            }
            if (!db.QuotesModels.Any(x => x.Id == int.Parse(id)))
            {
                return NotFound();
            }
            quote.Id = int.Parse(id);
            quote.InsertDate = DateTime.UtcNow;
            db.Update(quote);
            await db.SaveChangesAsync();
            return Ok(quote);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QuotesModel>> Delete(int id)
        {
            QuotesModel quote = db.QuotesModels.FirstOrDefault(x => x.Id == id);
            if (quote == null)
            {
                return NotFound();
            }
            db.QuotesModels.Remove(quote);
            await db.SaveChangesAsync();
            return Ok(quote);
        }

        /*[HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute]string id, [FromBody]PhoneModel model)
        {
            var exist = Phones.Any(p => p.Id == Guid.Parse(id));
            if (!exist) return NotFound();

            Phones.ForEach(p =>
            {
                if (p.Id == Guid.Parse(id))
                {
                    p.Model = model.Model;
                }
            });

            return Ok(new { Result = "Modified" });
        }*/

    }
}
