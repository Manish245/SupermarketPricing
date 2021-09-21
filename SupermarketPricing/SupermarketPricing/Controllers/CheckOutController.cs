using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupermarketPricing.InputModel;

namespace SupermarketPricing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckOutController : ControllerBase
    {

        [HttpPost()]
        public HttpResponse CheckOut([FromBody] List<Items> items)
        { 

        }
    }
}