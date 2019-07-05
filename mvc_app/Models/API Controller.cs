using mvc_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Form.Models
{
    public partial class API_Controller
    {

        private readonly HttpClient _httpClient;
        private Uri BaseEndpoint { get; set; }

        public API_Controller(Uri baseEndpoint)
        {
            if (baseEndpoint == null)
            {
                throw new ArgumentNullException("baseEndpoint");
            }
            BaseEndpoint = baseEndpoint;
            _httpClient = new HttpClient();
        }

        /// <summary>  
        /// Common method for making GET calls  
        /// </summary>  
        private async Task<T> GetAsync<T>(Uri requestUrl)
        {
            //addHeaders();
            var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        /// <summary>  
        /// Common method for making POST calls  
        ///// </summary>  
        private async Task<Message<T>> PostAsync<T>(Uri requestUrl, T content)
        {
            //addHeaders();
            var response = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T>(content));

            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T>>(data);
        }
        ////post call
        //private async Task<Message<T1>> PostAsync<T1, T2>(Uri requestUrl, T2 content)
        //{
        //    /*ddHeaders();*/
        //    var response = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T2>(content));
        //    response.EnsureSuccessStatusCode();
        //    var data = await response.Content.ReadAsStringAsync();
        //    return JsonConvert.DeserializeObject<Message<T1>>(data);
        //}

        private Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndpoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }
        //POST requst
        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

      

        //private void addHeaders()
        //{
        //    _httpClient.DefaultRequestHeaders.Remove("userIP");
        //    _httpClient.DefaultRequestHeaders.Add("userIP", "192.168.1.1");
        //}
    }

    public partial class API_Controller
    {  
        public async Task<List<User>> GetUsers()  
        {  
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,   
                "users"));  
            return await GetAsync<List<User>>(requestUrl);  
        }

        public async Task<Message<User>> SaveUser(User model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "users"));
            return await PostAsync<User>(requestUrl, model);
        }
    }
}

