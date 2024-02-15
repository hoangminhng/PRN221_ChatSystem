using PRN221ProjectGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public string ConversationName { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public bool isGroup { get; set; }
        public List<Message> MessagesReceived { get; set; }
    }
}
