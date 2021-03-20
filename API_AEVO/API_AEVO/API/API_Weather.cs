using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace API_AEVO.API
{
    public class API_Weather
    {
        public enum TipoConsumo {
            current,
            forecast,
            autocomplete,
        }


        private string sAccess_Key = "";
        private string sBaseUrl = "http://api.weatherstack.com/";


        public API_Weather(string Access_Key) {
            sAccess_Key = Access_Key;         
        }

        public async Task<string> GetApi(string Parametros, TipoConsumo Tipo ) {
            using (var httpClient = new HttpClient())
            {
                string Url = sBaseUrl + Tipo.ToString() + "?access_key=" + sAccess_Key;

                Url += "&" + Parametros;

                using (var response = await httpClient.GetAsync(Url))
                {
                    return await response.Content.ReadAsStringAsync();                    
                }
            }
        }

        

    }
}
