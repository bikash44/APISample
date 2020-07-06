using System;
using APITest.Common;
using APITest.Model;
using APITest.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITest.Controllers
{   
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private IBusinessDataService _businessDataService { get; }
        public SampleController(IBusinessDataService businessDataService)
        {
            this._businessDataService = businessDataService;
        }
        // POST api/<controller>
        [HttpPost(nameof(PostUserData))]
        public APIResponse PostUserData(User model)
        {
            try
            {
                var result = _businessDataService.UserDataConversion(model);

                return APIResponse.OK("Success", result);
            }
            catch (Exception ex)
            {
                return APIResponse.InternalError(ex);
            }
           
        }
    }
}
