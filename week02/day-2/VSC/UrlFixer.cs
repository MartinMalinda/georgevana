using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("bots", "odds").Insert(5, ":");
            Console.WriteLine(url);

// SEcond soluction
            
            url = url.Substring(0, url.Length - 4).Insert(5, ":") + "odds";
            Console.WriteLine(url);
        }
    }
}