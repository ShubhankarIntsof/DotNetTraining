using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DEMO_FrontEnd.Models
{
    public class EmployeeClient
    {   //https://localhost:44306/api/Employee_Shuba

        private string BASE_URL = "https://localhost:44306/api/";
        public IEnumerable<EmployeeModel> FindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("Employee_Shuba").Result;
                //var response = client.GetAsync("Employee_Shuba").Result;
                if (response.IsSuccessStatusCode)
                {
                    return (IEnumerable<EmployeeModel>)response.Content.ReadAsAsync<EmployeeModel>().Result;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //throw;
                return null;
            }
        }

        public IEnumerable<EmployeeModel> Find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response_ = client.GetAsync("Employee_Shuba/" + id.ToString()).Result;
                //var response = client.GetAsync("Employee_Shuba").Result;
                if (response_.IsSuccessStatusCode)
                {
                    return (IEnumerable<EmployeeModel>)response_.Content.ReadAsAsync<EmployeeModel>().Result;
                }
                return null;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //throw;
                return null;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response_ = client.DeleteAsync("Employee_Shuba/" + id.ToString()).Result;
                //var response = client.GetAsync("Employee_Shuba").Result
                return response_.IsSuccessStatusCode;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //throw;
                return false;
            }
        }
    }
}