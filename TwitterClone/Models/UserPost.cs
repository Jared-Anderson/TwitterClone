using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TwitterClone.Models
{

    

    public class UserPost
    {
        //Constructor
        public UserPost(int num, string first, string last, string words)
        {
            this.PostId = num;
            this.FirstName = first;
            this.LastName = last;
            this.Body = words;

        }

            // Id is the default key but for readability the key for this class is named PostId
            [Key]
            public int PostId { get; set; }

            public string FirstName{get; set;}
            public string LastName { get; set; }
            public string Body { get; set; }
            public DateTime PostDate { get; set; }


           // public virtual ICollection<UserPost> Posts { get; set; }
           // public IEnumerator<UserPost> GetEnumerator() { return this.Posts.GetEnumerator(); }
    }

}


