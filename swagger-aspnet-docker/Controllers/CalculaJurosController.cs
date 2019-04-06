using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace swagger_aspnet_docker.Controllers
{
    public class CalculaJurosController : ApiController
    {
        [Route("calculajuros")]
        [Route("CalculaJuros/ValorFinal")]
        public string Get(decimal valorinicial, int meses)
        {
            var juros = 0.01;
            var pow = decimal.Parse((Math.Pow((1 + juros), meses)).ToString());
            var valorFinal = valorinicial * pow;
            return String.Format("{0:0,00}", valorFinal.ToString("N", new CultureInfo("pt-BR")));
        }
    }
}
