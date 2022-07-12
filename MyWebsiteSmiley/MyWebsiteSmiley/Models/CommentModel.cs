using System;

namespace MyWebsiteSmiley.Models
{
    public class CommentModel
    {
        int commentId;
        UserModel whoCommented;
        string text;
        DateTime date;

        public CommentModel(int commentId, UserModel whoCommented, string text, DateTime date)
        {
            this.commentId = commentId;
            this.whoCommented = whoCommented;
            this.text = text;
            this.date = date;
        }
    }
}
