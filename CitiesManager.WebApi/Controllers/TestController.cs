using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        //[Route("Method1")]
        public string Method1()
        {
            //Method2();
            return "Return values from Method 1111111111111";
        }
        //[HttpGet]
        //[Route("Method2")]

        //public string Method2()
        //{
        //    return "Return values from Method 2222222222222";
        //}
    }
}
