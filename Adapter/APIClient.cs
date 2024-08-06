using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class APIClient
    {
        private HttpClient _client;
        public APIClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetHttpHeader(string url)
        {
            var result = await _client.GetAsync(url);
            return result.Content.Headers.ToString();
        }


    }
}
