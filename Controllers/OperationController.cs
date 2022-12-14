using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plesk.DataAccessLayer;
using Plesk.Model;

namespace Plesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationDL _operationDL; // Dependencies Injection

        public OperationController(IOperationDL operationDL) {
            _operationDL = operationDL;
        }
        [HttpPost]
        public async Task<IActionResult> InsertRecord() {

            InsertRecordResponse response = new InsertRecordResponse();

            try
            {

            }
            catch (Exception ex)
            {
                response.Issuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }
            return Ok(response);
        }
    }
}
            