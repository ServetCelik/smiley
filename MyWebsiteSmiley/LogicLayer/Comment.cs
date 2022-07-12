using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Comment
    {
        int commentId;
        User whoCommented;
        string text;
        DateTime date;

        public Comment(User whoCommented, string text)
        {            
            this.whoCommented = whoCommented;
            this.text = text;
            this.date = DateTime.Now;
        }

        public Comment(int commentId, User whoCommented, string text, DateTime date)
        {
            this.commentId = commentId;
            this.whoCommented = whoCommented;
            this.text = text;
            this.date = date;
        }
        public Comment()
        {

        }
    }
}
