using System;
using System.Collections.Generic;
using System.Text;

namespace Blog_Post
{
    public class BlogPost
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; }

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            this.AuthorName = authorName;
            this.Title = title;
            this.Text = text;
            this.PublicationDate = publicationDate;
        }
    }
}
