using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MoviesProject.Services
{
    public class ServiceClient
    {
        private HttpClient httpClient;
        private bool _IsConnection { get { return CheckInternet(); } }
        public bool IsConnection { get { return _IsConnection; } }

        public ServiceClient()
        {
            //Create new instance
            httpClient = new HttpClient(new HttpClientHandler());
            //Sign the base URL on http 
            httpClient.BaseAddress = new Uri("https://6f429185.ngrok.io", UriKind.Absolute);
            //Type of the request as json
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        //Get Method
        public async Task<T> GetAsync<T>(string URL) where T : class
        {
            //Check the connection 
            if (IsConnection)
            {
                try
                {
                    //Call the get method and the url for parametar
                    var result = await httpClient.GetAsync(URL);
                    //Check if connection is return ok 
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //Convert the restult and return as object
                        return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
                    }
                    else
                        //Return null when status not ok
                        return null;
                }
                catch (Exception ex)
                {
                    //We have some issue here
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
            //Don't have connection
            return null;
        }

        //Post Method 
        public async Task<T> PostAsync<T>(string url, object param) where T : class
        {
            //Check the connection
            if (IsConnection)
            {
                try
                {
                    //Convert the object to json
                    var jsonParam = JsonConvert.SerializeObject(param);
                    //Send json and content with body request
                    var httpContent = new StringContent(jsonParam, Encoding.UTF8, "application/json");
                    var result = await httpClient.PostAsync(url, httpContent);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
                    }
                    else
                        //Return null when status not ok 
                        return null;
                }
                catch (Exception ex)
                {
                    //We have some issue here
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
            //Don't have connection
            return null;
        }

        //Put Method
        public async Task<bool> PutAsync(string url, object param)
        {
            //Check the connection
            if (IsConnection)
            {
                try
                {
                    //Convert the object to json
                    var jsonParam = JsonConvert.SerializeObject(param);
                    //Send json and content with body request
                    var httpContent = new StringContent(jsonParam, Encoding.UTF8, "application/json");
                    var result = await httpClient.PutAsync(url, httpContent);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                        //Return Null when status not OK
                        return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
            else
                //Don't have connection 
                return false;
        }

        //Delete Method
        public async Task<bool> DeleteAsync(string url)
        {
            //Check the connection
            if (IsConnection)
            {
                try
                {
                    var result = await httpClient.DeleteAsync(url);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                        //Return Null when status not OK
                        return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
            else
                //Don't have connection 
                return false;
        }

        //Check Internet and wifi
        bool CheckInternet()
        {
            //Return the bool after check the connection
            return Connectivity.NetworkAccess == NetworkAccess.Internet;
        }
    }
}
