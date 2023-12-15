using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Models
{
    public class AdminCommentUpdate
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
    }
}
