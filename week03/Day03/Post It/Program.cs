using System;

namespace Post_It
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a PostIt a struct that has
                a BackgroundColor
                a Text on it
                a TextColor
            Create a few example post-it objects:
                an orange with blue text: "Idea 1"
                a pink with black text: "Awesome"
                a yellow with green text: "Superb!"*/

            PostIt PostItOne = new PostIt("Orange", "Idea1", "Blue");
            PostIt PostItTwo = new PostIt("Pink", "Awesome", "Black");
            PostIt PostItThree = new PostIt("Yellow", "Superb", "Green");

        }
    }
}
