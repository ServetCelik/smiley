using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Post
    {
        int postId;
        string title;
        string imgURL;
        User whoPosted;
        int totalVotes;
        List<Comment> comments;
        DateTime date;

        public Post()
        {
        }

        public Post(string title, string imgURL, User whoPosted)
        {
            //this.postId = postId;
            this.title = title;
            this.imgURL = imgURL;
            this.whoPosted = whoPosted;
            this.totalVotes = 0;
            this.comments = new List<Comment>();
            this.date =DateTime.Now;
        }
        

        public int PostId { get => postId; set => postId = value; }
        public string Title { get => title; set => title = value; }
        public string ImgURL { get => imgURL; set => imgURL = value; }
        public int TotalVotes { get => totalVotes; set => totalVotes = value; }
        public DateTime Date { get => date; set => date = value; }
        internal User WhoPosted { get => whoPosted; set => whoPosted = value; }
        internal List<Comment> Comments { get => comments; set => comments = value; }
    }
}
