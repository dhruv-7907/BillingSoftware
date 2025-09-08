using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RestSharp;
namespace Billing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        [HttpGet("private")]
        public IActionResult Private()
        {
            var client = new RestClient("https://dev-k2r55bqwyprpn2qf.us.auth0.com/oauth/token");
            //var request = new RestRequest(Method.POST);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"client_id\":\"BCyKTYrmlwcXXILnWPsw6bBRRCJTgwaM\",\"client_secret\":\"KPbMVsd_l31muEnMYZEmybZQWqJCALYaXMqKjg-bokZuL-jCtVVlDpSbTHsmi-qM\",\"audience\":\"https://ciplatform/api\",\"grant_type\":\"client_credentials\"}", ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.ToString());
            return Ok(response);
        }

        [HttpGet("private-scoped")]
               [Authorize]
               public IActionResult Scoped()
               {
                   return Ok(new
                   {
                       Message = "Dhruv Patel 11"
                   });
               }
    }
}