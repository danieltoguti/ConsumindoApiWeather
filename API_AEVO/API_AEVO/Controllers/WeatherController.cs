using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_AEVO.API;
using Microsoft.AspNetCore.Mvc;

namespace API_AEVO.Controllers
{

    public class WeatherController : Controller
    {
        string Key_API = "7f85107df76031c90f8f57a8be209d10";

        [HttpGet]
        public IActionResult GetCurrent(string query)
        {

            if (String.IsNullOrEmpty(query))
            {
                return Json(new { status = false, resposta = "Infome o Parâmetro" });
            }

            API_Weather api = new API_Weather(Key_API);
            string Parametros = "";
            Parametros += "query=" + query;
            var resp = api.GetApi(Parametros, API_Weather.TipoConsumo.current);
            return Json(new { status = true, resposta = resp });
        }


        [HttpGet]
        public IActionResult GetForescat(string query)
        {

            if (String.IsNullOrEmpty(query))
            {
                return Json(new { status = false, resposta = "Infome o Parâmetro" });
            }

            API_Weather api = new API_Weather(Key_API);
            string Parametros = "";
            Parametros += "query=" + query + "&forestcast_days=1&hourly=1";

            var resp = api.GetApi(Parametros, API_Weather.TipoConsumo.forecast);
            return Json(new { status = true, resposta = resp });
        }

        [HttpGet]
        public IActionResult GetAutocomplete(string query)
        {

            if (String.IsNullOrEmpty(query))
            {
                return Json(new { status = false, resposta = "Infome o Parâmetro" });
            }

            API_Weather api = new API_Weather(Key_API);
            string Parametros = "";
            Parametros += "query=" + query;

            var resp = api.GetApi(Parametros, API_Weather.TipoConsumo.autocomplete);
            return Json(new { status = true, resposta = resp });
        }

    }
}