using Plesk.Model;

namespace Plesk.DataAccessLayer
{
    public class OperationDL : IOperationDL
    {
        private IConfiguration _configuration;

        public OperationDL(IConfiguration configuration) {
            _configuration = configuration;
        }

        public async Task<InsertRecordResponse> InsertRecord(InsertRecordRequest request)
        {
            InsertRecordResponse response = new InsertRecordResponse();
            try
            {

            }
            catch (Exception ex)
            {

                response.Issuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }
            return response;
        }
    }

}
