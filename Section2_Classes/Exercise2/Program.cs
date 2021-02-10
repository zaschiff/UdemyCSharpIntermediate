using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post newPost = new Post();
            newPost.AddTitle("Testing a new Post");
            newPost.AddDesc(@"This message is a testing of the new 
posting system and will need to be built in 
order to make sure the description field is working 
accordingly when displayed");
            for(var i = 0; i <= 10; i++) {
                newPost.AddUpVote();
            }

            for(var i = 0; i < 5; i++) {
                newPost.AddDownVote();
            }

            Console.WriteLine(newPost.DisplayInfo());
        }
    }
}
