using CRUDoperations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDoperations.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;
        public UserController(UserDbContext userDbContext)
        {
            _context = userDbContext;
        }



        // list or get all method
        public IActionResult Index()
        {
            var userModeltoview = _context.Users.ToList();
            return View(userModeltoview);
        }
        [HttpGet]
        // (update) create Method get by Id
        public IActionResult AddOrEdit(int Id = 0)
        {
            UserModel userModel = new UserModel();
            if (Id == 0)
                return View(userModel);
            else
                return View(_context.Users.Find(Id));
        }

        // save and edit the record

        [HttpPost]
        public IActionResult AddOrEdit([Bind("Id,FirstName,LastName,ContactNo")] UserModel userModelobj)
        {
           if (ModelState.IsValid)
            {
                if (userModelobj.Id == 0)
                {
                    _context.Add(userModelobj);
                }
                if (userModelobj.Id > 0)
                {
                    _context.Update(userModelobj);
                }

                _context.SaveChanges();
                

            }

            return RedirectToAction(nameof(Index));

        }


        // Delete record
        [HttpPost , ActionName("Delete")]
       public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var p = await _context.Users.FindAsync(id);
            _context.Users.Remove(p);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
