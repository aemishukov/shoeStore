using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class ShoeService
    {
        private readonly IShoeRepository shoeRepository;

        public ShoeService(IShoeRepository shoeRepository)
        {
            this.shoeRepository = shoeRepository;
        }

        public Shoe[] GetAllByQuery(string query)
        {
            if (Shoe.IsArticle(query))
            {
                return shoeRepository.GetByArticle(query);
            }

            return shoeRepository.GetAllByTitleOrCompanyName(query);
        }
    }
}
