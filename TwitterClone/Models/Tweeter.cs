
using System.Collections.Generic;

namespace TwitterClone.Models
{
    public class Tweeter 
    {
        public List<UserPost> UserPosts;
        public bool HasProfilePic { get; set; }
    }
}