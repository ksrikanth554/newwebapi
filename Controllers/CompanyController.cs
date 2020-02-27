using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companies.Models;
using Companies.Services;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Controllers{
    [Route("api/[controller]")]
    [ApiController]
public class CompanyController:ControllerBase{

    CompanyService _companyService;

       public CompanyController(CompanyService _companyService)
       {
            this._companyService=_companyService;
       }

        [HttpGet]
       public ActionResult Get()
       {
            return Ok(_companyService.GetCompany());
       }
       [HttpPost]

       public ActionResult Post(Company company)
       {
           this._companyService.AddCompany(company);
           return Ok();

       }
       

      



}






}