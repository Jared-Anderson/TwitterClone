using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    public class UserPost
    {
        public UserPost(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
            public int Id { get; set; }
            public string Name{get; set;}
    }
}
