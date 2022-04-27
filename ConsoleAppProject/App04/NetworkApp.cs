using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        
        /// <summary>
        ///  This method will display all the options
        ///  available withing the application.
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("   --->  Ionut Boris's Feed  <---    ");
            string[] choices = new string[]
            {
                "Post Message", "Post Image", " " + "Display all posts",
                "Remove Post", "Add Comments","Like Post","Dislike Posts","Display by Author", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: Postimage(); break;
                    case 3: DisplayAll(); break;
                    case 4: RemovePost();break;
                    case 5: AddComment();break;
                    case 6: LikePosts();break;
                    case 7: DislikePost();break;
                    case 8: DisplayByAuthor();break;
                    case 9: wantToQuit = true; break;
                }
                DisplayMenu();


            } while (wantToQuit);
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void DislikePost()
        {
            throw new NotImplementedException();
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Calling the Display methot from the NewsFeed class.
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        private void Postimage()
        {
            ConsoleHelper.OutputTitle("Posting an image ");
            string author = InputName();
            Console.WriteLine("Please enter your image filename > ");
            string filename = Console.ReadLine();
            Console.WriteLine("Please enter your image caption >");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(author,filename,caption);
            news.AddPhotoPost(post);
            ConsoleHelper.OutputTitle("You have posted this image: ");
            post.Display();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a message ");
            string author = InputName();
            Console.WriteLine("Please enter your message > ");
            string message = Console.ReadLine();
           
           MessagePost post = new MessagePost(author,message);
            news.AddMessagePost(post);
            ConsoleHelper.OutputTitle("You have posted this message: ");
            post.Display();
        }

        private string InputName()
        {
            Console.WriteLine("Please enter your name -> ");
            string author = Console.ReadLine();
            return author;
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a post  :");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post ID -> ");
            news.RemovePost(id);
        }

    }
}
