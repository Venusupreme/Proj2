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
                new Maintenance_Requests{ID=1234567890,First_Name="Raven",Last_Name="Halbruner",Check_In_Time=DateTime.Parse("2024-01-01 12:00:00"),Check_Out_Time=DateTime.Parse("2024-01-01 12:30:49")}

            };
            //accessContext.Maint_Req_Table.AddRange(CheckIn);
            accessContext.SaveChanges();
        }
    }
}

