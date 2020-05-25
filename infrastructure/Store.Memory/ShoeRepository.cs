using System;
using System.Linq;

namespace Store.Memory
{
    public class ShoeRepository : IShoeRepository
    {
        private readonly Shoe[] shoes = new[]
        {
            new Shoe(1, "Blue suede shoes"),
            new Shoe(2, "Blood red shoes"),
            new Shoe(1, "Dancing shoes"),
        };

        public Shoe[] GetAllByTitle(string titlePart)
        {
            return shoes.Where(shoe => shoe.Title.Contains(titlePart)).ToArray();
        }
    }
}