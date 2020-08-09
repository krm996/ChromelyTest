using Chromely.Core.Network;

namespace ChrTet
{
    public class DemoController : ChromelyController
    {
        [HttpGet(Route = "/Democontroller/Movies")]
        public ChromelyResponse Movies(ChromelyRequest request)
        {
            return new ChromelyResponse();
        }
    }
}

