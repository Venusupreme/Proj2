using System;
using System.ComponentModel.DataAnnotations;
namespace Proj2.Models
{
    public class Maintenance_Requests
    {
        [Key]
        public int ID{get; set;}

        public int Request_ID{get; set;}

        public int Tenant_ID{get; set;}

        public DateTime Date{get; set;}

        public string Location_1{get; set;}

        public string Details_1{get; set;}

        public string Location_2{get; set;}

        public string Details_2{get; set;}

        public string Location_3{get; set;}

        public string Details_3{get; set;}

        public int Completion_Status{get; set;}

        public string Comments{get; set;}
    }
}