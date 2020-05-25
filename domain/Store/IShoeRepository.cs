using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface IShoeRepository
    {
        Shoe[] GetAllByTitle(string titlePart);
    }
}
