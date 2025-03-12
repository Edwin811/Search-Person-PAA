using System;
using Microsoft.AspNetCore.Mvc;
using percobaan2.Models;

namespace percobaan2.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("api/person")]
        public IActionResult GetAction(int id_person)
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();

            Person Cari = null;

            foreach (Person i in ListPerson)
            {
                if (i.id_person == id_person)
                {
                    Cari = i;
                    break;
                }
            }

            if (Cari == null)
            {
                return NotFound("id orang tersebut tidak ditemukan");
            }

            return Ok(Cari);
        }

    }
}