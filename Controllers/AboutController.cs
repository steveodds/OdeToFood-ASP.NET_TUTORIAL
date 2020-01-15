using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "+254-702-276-227";
        }

        public string Address()
        {
            return "Kenya";
        }
    }
}
