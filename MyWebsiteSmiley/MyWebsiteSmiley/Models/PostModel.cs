using System;
using System.Collections.Generic;

namespace MyWebsiteSmiley.Models
{
    public class PostModel
    {
        int postId;
        string title;
        string imgURL;
        UserModel whoPosted;
        int totalVotes;
        List<CommentModel> comments;
        DateTime date;

        //postid will be added after this constructure will be saved in sql db
        public PostModel(string title, string imgURL/*, UserModel whoPosted*/,DateTime date)
        {
            this.title = title;
            this.imgURL = imgURL;
            //this.whoPosted = whoPosted;
            this.totalVotes = 0;
            this.comments = null;
            this.date = date;
        }

        public int PostId { get => postId; set => postId = value; }
        public string Title { get => title; set => title = value; }
        public string ImgURL { get => imgURL; set => imgURL = value; }
        public UserModel WhoPosted { get => whoPosted; set => whoPosted = value; }
        public int TotalVotes { get => totalVotes; set => totalVotes = value; }
        public List<CommentModel> Comments { get => comments; set => comments = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
