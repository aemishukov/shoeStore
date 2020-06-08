using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IShoeRepository
    {
        Shoe[] GetByArticle(string article);
        Shoe[] GetAllByTitleOrCompanyName(string titleOrCompanyName);
    }
}
