using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44358/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }


        public async Task<IActionResult> AddEmployee(Class1 c)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(c);
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var values = await httpClient.PostAsync("https://localhost:44358/api/Default", content);
            if (values.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else {
                return NotFound();
            }
            
        }


    }

    public class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
