using Microsoft.AspNetCore.Mvc;
using AppLogic;
using DTO;

namespace AndresVillalobos.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoanController : ControllerBase
    {
        [HttpGet]
        public List<Loan> GetArticlesValue()
        {
            LoanManager lm = new LoanManager();

            return lm.GetAllLoans();
        }
    }
}
