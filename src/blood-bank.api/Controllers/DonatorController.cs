using blood_bank.application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace blood_bank.api.Controllers
{
    public class DonatorController : ControllerBase
    {
        public DonatorController()
        {

        }

        [HttpPost]
        public IActionResult Post([FromBody] AddressInputModel addressInput)
        {
            return new OkResult();
        }
    }
}