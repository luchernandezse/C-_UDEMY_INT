using System;

namespace Blog_Counter
{
    public class Blog
    {
        public String Title;
        public String Description;
        public DateTime DateTime;
        private int _voteValue;
        public Blog()
        {

        }
        public Blog(string title, string Description)
        {
            this.Title = title;
            this.Description = Description;
            DateTime = DateTime.Now;
        }
        public void vote_up()
        {
            _voteValue += 1;
        }
        public void vote_down()
        {
            _voteValue -= 1;
        }
        public void vote_total()
        {
            Console.WriteLine("The total votes for this post are: {0}", _voteValue);
        }


    }
}
