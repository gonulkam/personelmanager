using Microsoft.AspNetCore.Mvc;
using personelmanager.Repository;

namespace personelmanager.Controllers
{
    public class PersonController : Controller
    {

        private readonly PersonRepository _personRepository;
        public PersonController()
        {
            _personRepository = new PersonRepository();
        }
        public IActionResult GetAll()
        {
            var persons = _personRepository.GetAll();

            return View(persons);
        }
        public IActionResult GetById(int id)
        {
            var person = _personRepository.GetById(id);
            return View(person);    
        }

    }
}
