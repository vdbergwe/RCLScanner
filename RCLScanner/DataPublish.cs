using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace RCLScanner
{


    internal class DataPublish
    {


        public async void Publish(string UpVbeln, string UpGRNumber, DateTime UpGRDate, string UpComputerName, string UpUsername, string UpIP, string UpDocumentName) {
            try
            {
                string url = "https://rclmlsdash01.tsb.co.za/Fetch/SetLog";


                // Create a new JSON object
                var jsonObject = new
                {
                    MANDT = "TSH",
                    SYSID1 = "021",
                    VBELN = UpVbeln,
                    GRNUMBER = UpGRNumber,
                    GRDate = UpGRDate,
                    ComputerName = UpComputerName,
                    Username = UpUsername,
                    ComputerIPV4 = UpIP,
                    ScanDate = DateTime.Now,
                    ScanTime = DateTime.Now,
                    SyncDate = DateTime.Now,
                    SyncTime = DateTime.Now,
                    DocumentName = UpDocumentName,
                    UserDomain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName
                };

                // Convert the object to a JSON string
                string jsonString = JsonConvert.SerializeObject(jsonObject);

                // Create a new HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Create a new StringContent with the JSON string
                    using (StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json"))
                    {
                        // Send the HTTP POST request
                        HttpResponseMessage response = await client.PostAsync(url, content);

                        // Check the response status
                        if (response.IsSuccessStatusCode)
                        {
                            Console.WriteLine("JSON object sent successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error sending JSON object. Status code: " + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
            
        }

    }
}
