using System.Collections.Generic;
using System.Web.Mvc;

namespace kiaraStudyGroup.Controllers
{
    public class PeopleController : Controller
    {

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel {  StudentNumber = "u24622975" , Name = "Kiara", Surname = "Krchnavy",  Email = "u24622975@tuks.co.za" });
            people.Add(new Models.PersonModel { StudentNumber = "u24652694", Name = "Kezia", Surname = "Segurado", Email = "u24652694@tuks.co.za" });
            people.Add(new Models.PersonModel { StudentNumber = "u25622625", Name = "Nicole", Surname = "Cooks", Email = "u25622625@tuks.co.za" });
            people.Add(new Models.PersonModel { StudentNumber = "u24722296", Name = "Dustin", Surname = "Pierdica", Email = "u24722296@tuks.co.za" });
            people.Add(new Models.PersonModel { StudentNumber = "u24572615", Name = "Angelique", Surname = "Tenente", Email = "u24572615@tuks.co.za" });

            return View(people);

        }
 
    }
}