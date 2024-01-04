using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Counter
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("EXCERSISE 2: COUNT A BLOG POST WITH LIKES\n" + "Design a class called Post. This class models a StackOverflow post. It should have properties \r\nfor title, description and the date/time it was created. We should be able to up-vote or down-vote \r\na post. We should also be able to see the current vote value. In the main method, create a post, \r\nup-vote and down-vote it a few times and then display the the current vote value.");

            Console.WriteLine("Welcome to the StackOverflow post project. You have already created a post. To vote up, enter 1. To vote down, enter 2. For exit hit 3.");

            var post_blog = new Blog("Primer post", "Mi primer post en stackoverflow");

            int order = Int32.Parse(Console.ReadLine());

            while (order != 3) { 
            if (order == 1)
            {
                post_blog.vote_up();
                post_blog.vote_total();
            }
            else if (order == 2)
            {
                post_blog.vote_down();
                post_blog.vote_total();
            }
            else
            {
                Console.WriteLine("Check for a valid option!!");
            }
                order = Int32.Parse(Console.ReadLine());
            }

            

            Console.WriteLine("ARTICLE RESUME:\n");
            Console.WriteLine("Titulo: " + post_blog.Title);
            Console.WriteLine("Descripcion: " + post_blog.Description);
            Console.WriteLine("Fecha: " + post_blog.DateTime);
            post_blog.vote_total();
        }
    }
}
