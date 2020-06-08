using System;
using System.Linq;

namespace Store.Memory
{
    public class ShoeRepository : IShoeRepository
    {
        private readonly Shoe[] shoes = new[]
        {
            new Shoe(1, "123456 AB", "Company 1", "Blue suede shoes"),
            new Shoe(2, "123456 B", "Company 2", "Blood red shoes"),
            new Shoe(3, "123456 AA", "Company 3", "Dancing shoes"),
        };

        public Shoe[] GetAllByTitleOrCompanyName(string query)
        {
            return shoes.Where(shoe => shoe.Title.Contains(query) || shoe.CompanyName.Contains(query))
                .ToArray();
        }

        public Shoe[] GetByArticle(string article)
        {
            return shoes.Where(shoe => shoe.Article == article)
                .ToArray();
        }
    }
}