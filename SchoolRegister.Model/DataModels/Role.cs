using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Role
    {
        public RoleValue RoleValue{get;set;}
        Role(){
        }
        Role(string Name,RoleValue roleValue){
        }
    }
}