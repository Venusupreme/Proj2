using Proj2.Models;
namespace Proj2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AccessContext accessContext)
        {
            // look for check in records
            if(accessContext.Maint_Req_Table.Any())
            {
                return;
            }
            var MaintReqs=new Maintenance_Requests[]
            {
                new Maintenance_Requests{ID=1234567890,Request_ID=0, Tenant_ID=0, Date=DateTime.Parse("2024-01-01 12:00:00"),Location_1="Test",Details_1="Test", Completion_Status=0}

            };
            //accessContext.Maint_Req_Table.AddRange(CheckIn);
            accessContext.SaveChanges();
        }
    }
}

