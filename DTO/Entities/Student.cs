using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar.DTO.Entities
{
    public class Student : IEntity
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string parent { get; set; }
        public string email_parent { get; set; }

    }
}