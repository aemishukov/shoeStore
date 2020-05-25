using System;

namespace Store
{
    public class Shoe
    {
        public int Id { get; }

        public string Title { get; }

        public Shoe(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
