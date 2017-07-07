using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;

namespace QuoteMachine.Helpers
{
    public class QuoteApiCall
    {
        readonly string uri = "http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=1";

        public async Task GetQuotes()
        {
            using (HttpClient httpClient = new HttpClient())
            {

            }
        }
    }
}