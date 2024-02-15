using PRN221ProjectGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string? Introduction { get; set; }
        public string Interest { get; set; }
        public string City { get; set; }

        public List<Photo> photos { get; set; } = new();
        public List<Friend> SentByUsers { get; set; }
        public List<Friend> SentUsers { get; set; }
        public List<Message> MessagesSent { get; set; }
    }
}
