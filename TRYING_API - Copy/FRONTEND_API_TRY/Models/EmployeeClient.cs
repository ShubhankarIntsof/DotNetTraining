using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace FRONTEND_API_TRY.Models
{
    public class EmployeeClient
    {
        //public Employee Employee = new Employee();

        private string BASE_URL = "https://localhost:44373/api/";

        public IEnumerable<Employee> Find()
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = client.GetAsync("Employee").Result;
                if (message.IsSuccessStatusCode)
                {
                    return message.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;

                //throw;
            }

        }

        public Employee FindID(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = client.GetAsync("Employee/" + id.ToString()).Result;
                if (message.IsSuccessStatusCode)
                {
                    return message.Content.ReadAsAsync<Employee>().Result;
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
                //throw;
            }

        }

        public bool Delete(string id)
        {

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = client.DeleteAsync("Employee/" + id).Result;

                return (message.IsSuccessStatusCode);
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }




    }
}