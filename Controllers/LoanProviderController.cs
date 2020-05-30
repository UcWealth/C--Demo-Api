using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Controller]
    [Produces("application/json")]
    public class LoanProviderController : ControllerBase
    {
        static List<string> _loanProviders = new List<string>() { "Cowrywise", "Renmoney", "Piggyvest" };
        [HttpGet("/loanproviders/getloanproviders")]
        public IActionResult GetLoanProviders()
        {

            return new OkObjectResult(_loanProviders);
        }
        [HttpPost("/loanproviders/addloanprovider")]
        public IActionResult AddLoanProvider(CreateLoanProviderRequestModel model)
        {
            _loanProviders.Add(model.Name);
            return CreatedAtAction(nameof(AddLoanProvider), null);
        }

    }
}