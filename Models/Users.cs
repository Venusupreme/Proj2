using System;
using System.ComponentModel.DataAnnotations;
namespace Proj2.Models
{
    public class Users
    {
        [Key]
        public int User_ID{get; set;}

        public string User_Type{get; set;}

        private string User_Password{get; set;}
    }
}