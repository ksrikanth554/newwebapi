using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using newwebapi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace newwebapi.Control
{
     [Route("api/[controller]")]
    [ApiController]
    public class CompanyController:Controller
    {

        private CompanyContext _companyContext;


        public CompanyController(CompanyContext context)
        {
            _companyContext=context;

        }

         [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            
           return _companyContext.CompanyNames.ToList();
        }
         [HttpPost]
        public async Task<IActionResult> Post (Company company)
        {
            //_companyContext.CompanyNames.Add(company);
           // _companyContext.CompanyNames.Update(company);
            _companyContext.Update(company);
           await _companyContext.SaveChangesAsync();
           return Ok();
          
        }


        ~CompanyController()
        {

            _companyContext.Dispose();
        }




    }
}
