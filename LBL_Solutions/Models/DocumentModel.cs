using Microsoft.EntityFrameworkCore;
namespace LBL_Solutions.Models
{
    public class DocumentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Overview { get; set; }

        public string Features { get; set; }

        public string Addtional { get; set; }

    }

}
