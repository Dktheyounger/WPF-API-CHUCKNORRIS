using ChuckNorrisJokes.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    class Retrieve
    {
        public static async Task<JokeModel> LoadJoke()
        {
            string url = "http://api.icndb.com/jokes/random?limitTo=[nerdy]";


            using (HttpResponseMessage response = await Initialization.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JokeModel joke = await response.Content.ReadAsAsync<JokeModel>();

                    return joke;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

