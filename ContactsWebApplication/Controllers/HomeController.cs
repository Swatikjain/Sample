using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApplication.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace ContactsWebApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IConfiguration _config;
        private readonly string apiEndpoint;
        public HomeController(IConfiguration config)
        {
            //_config = config;
            apiEndpoint = config.GetSection("Endpoints").GetValue<string>("Api");
        }


        public IActionResult Index()
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(apiEndpoint);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var responseMessage = client.GetAsync(client.BaseAddress);

                    var response = responseMessage.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsStringAsync();
                        //var jsonResult = JsonConvert.DeserializeObject<GetDocuments>(data.Result);
                        var jsonResult = JsonConvert.DeserializeObject<IEnumerable<ContactModel>>(data.Result);
                        return View(jsonResult);
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }

            return View();
        }

       
        [Route("/{id}")]
        public IActionResult Edit(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiEndpoint+"/"+id);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var responseMessage = client.GetAsync(client.BaseAddress);

                    var response = responseMessage.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsStringAsync();
                        var jsonResult = JsonConvert.DeserializeObject<ContactModel>(data.Result);
                        return View("Edit", jsonResult);
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
            return View();
        }

        [HttpPost]
        [Route("/{id}")]
        public ActionResult Edit(int id, ContactModel contact)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiEndpoint + "/" + contact.Id);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    var json = JsonConvert.SerializeObject(contact);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var responseMessage = client.PutAsync(client.BaseAddress, data);                    
                    var response = responseMessage.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactModel contact)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiEndpoint);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    contact.IsActive = true;
                    var json = JsonConvert.SerializeObject(contact);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var responseMessage = client.PostAsync(client.BaseAddress, data);
                    var response = responseMessage.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiEndpoint + "/" + id);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                        
                    var responseMessage = client.DeleteAsync(client.BaseAddress);
                    var response = responseMessage.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
