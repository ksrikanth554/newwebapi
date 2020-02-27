using System.Collections.Generic;
using Companies.Models;

namespace Companies.Services{

    public class CompanyService{

            List<Company> _companyList=null;

            public CompanyService()
            {
                _companyList=new List<Company>();
            }

            public List<Company> GetCompany()
            {
                 return _companyList;   

            }
            public void AddCompany(Company company)
            {

                _companyList.Add(company);
            }


    }

}