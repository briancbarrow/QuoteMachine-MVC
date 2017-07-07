using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;

namespace QuoteMachine.Helpers
{
    public class QuoteApiCall
    {
        readonly string uri = "http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=1";
        private HttpClient _httpClient = new HttpClient();
        public string Result { get; private set; }
        public async Task GetQuotes()
        {
            Result = await _httpClient.GetStringAsync(uri);
        }
    }
}