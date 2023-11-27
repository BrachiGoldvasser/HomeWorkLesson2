using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BHHWLesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HWLesson2Controller : ControllerBase
    {
        List<string> strings = new List<string>();
        public void FillList()
        {
            strings.Add("Shoshi");
            strings.Add("Brachi");
            strings.Add("Dasi");
        }

      


    }
}
