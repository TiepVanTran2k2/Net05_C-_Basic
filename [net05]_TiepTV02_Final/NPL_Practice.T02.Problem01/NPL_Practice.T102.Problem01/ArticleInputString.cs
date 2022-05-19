using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL_Practice.T102.Problem01
{
    class ArticleInputString
    {
        public void InputString()
        {
            string content_of_article;
            int max_length_of_summary;
            Console.Write("Input: ");
            content_of_article = Console.ReadLine();
            Console.Write("Max length: ");
            max_length_of_summary = int.Parse(Console.ReadLine());
            string article = GetArticleSummary(content_of_article, max_length_of_summary);
            Console.WriteLine("Article Summary: {0}", article);
        }
        static public string GetArticleSummary(string content, int maxLength)
        {
            string ArticleSummary;
            if (maxLength >= content.Length)
            {
                return content;
            }
            ArticleSummary = content.Substring(0, maxLength) + "....";
            return ArticleSummary;
        }
    }
}
