using System.ComponentModel.DataAnnotations;

namespace LBL_Solutions.Models
{
    public class ContactMsgModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
