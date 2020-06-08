using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Shoe
    {
        public int Id { get; }

        public string Article { get; }

        public string CompanyName { get; }

        public string Title { get; }

        public Shoe(int id, string article, string companyName, string title)
        {
            Id = id;
            Article = article;
            CompanyName = companyName;
            Title = title;
        }

        internal static bool IsArticle(string s)
        {
            if (s == null)
                return false;
            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();
            return Regex.IsMatch(s, @"^\d{6}[A-B]{1,2}$");
        }
    }
}
