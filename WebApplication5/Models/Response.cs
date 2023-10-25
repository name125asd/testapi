using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Response
    {
        public string name { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public string email { get; set; }
        public bool is_student { get; set; }

        public class Address
        {
            public string street { get; set; }
            public string city { get; set; }
            public string postal_code { get; set; }
        }

    }


}