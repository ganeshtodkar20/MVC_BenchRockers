using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using BenchRockers.Models;

namespace BenchRockers.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        private BenchRockersDbContext db = new BenchRockersDbContext();
        public ActionResult Index()
        {
            return View();
           
        }

        public ActionResult PagingAndSorting()
        {
            return View();
        }

        public ActionResult PAS()
        {
            return View();
        }



        [HttpPost]
        public JsonResult PersonList(int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null)
        {
            try
            {
                Thread.Sleep(200);
                var personCount = db.Persons.Count();
                var persons = GetPersons(jtStartIndex, jtPageSize, jtSorting);
                return Json(new { Result = "OK", Records = persons, TotalRecordCount = personCount });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


        public List<Person> GetPersons(int startIndex, int count, string sorting)
        {
            IEnumerable<Person> query = db.Persons;

            //Sorting
            //This ugly code is used just for demonstration.
            //Normally, Incoming sorting text can be directly appended to an SQL query.
            if (string.IsNullOrEmpty(sorting) || sorting.Equals("Name ASC"))
            {
                query = query.OrderBy(p => p.Name);
            }
            else if (sorting.Equals("Name DESC"))
            {
                query = query.OrderByDescending(p => p.Name);
            }
            else if (sorting.Equals("Gender ASC"))
            {
                query = query.OrderBy(p => p.Gender);
            }
            else if (sorting.Equals("Gender DESC"))
            {
                query = query.OrderByDescending(p => p.Gender);
            }           
            else
            {
                query = query.OrderBy(p => p.Name); //Default!
            }

            return count > 0
                       ? query.Skip(startIndex).Take(count).ToList() //Paging
                       : query.ToList(); //No paging
        }

    

        //[HttpPost]
        //public JsonResult PersonList()
        //{
        //    try
        //    {
        //        List<Person> persons = db.GetAllPersons();
        //        return Json(new { Result = "OK", Records = persons });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

    }
}
