using System;
using System.Net.Http;

namespace EmployeeEventApp.Publisher
{
    public delegate void ProcessingData();
    class Employee
    {
        public event ProcessingData OnProcessingCompleted = null;

        async public void ProcessData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.GetAsync(url))
                {
                    using (HttpContent content = responseMessage.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        Console.WriteLine("Data Loading ......\n"+data);
                        OnProcessingCompleted?.Invoke();
                    }
                }
            }
        }

    }

}
