
using System;
using System.Collections.Generic;

namespace TwitterClone.Models
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; set; }
        public virtual ICollection<UserPost> UserPosts { get; set; }
        public bool HasProfilePic { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}