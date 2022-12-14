using Plesk.Model;

namespace Plesk.DataAccessLayer
{
    public interface IOperationDL
    {
        public Task<InsertRecordResponse>InsertRecord(InsertRecordRequest request);
    }
}
