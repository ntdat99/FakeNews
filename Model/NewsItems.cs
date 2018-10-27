using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews.Model
{
   public class NewsItems 
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }

    }
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItems> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));

        }

        private static List<NewsItems> getNewsItems()
        {
            var items = new List<NewsItems>();
            items.Add(new NewsItems() { Id = 1, Category = "Financial", Headline ="headline1", Subhead="Sub1", Image="none" });

            items.Add(new NewsItems() { Id = 2, Category = "Financial", Headline = "headline2", Subhead = "Sub2", Image = "none" });

            items.Add(new NewsItems() { Id = 3, Category = "Financial", Headline = "headline3", Subhead = "Sub3", Image = "none" });

            items.Add(new NewsItems() { Id = 4, Category = "Financial", Headline = "headline4", Subhead = "Sub4", Image = "none" });

            items.Add(new NewsItems() { Id = 5, Category = "Financial", Headline = "headline5", Subhead = "Sub5", Image = "none" });

            items.Add(new NewsItems() { Id = 6, Category = "Financial", Headline = "headline6", Subhead = "Sub6", Image = "none" });

            items.Add(new NewsItems() { Id = 7, Category = "Financial", Headline = "headline7", Subhead = "Sub7", Image = "none" });

            items.Add(new NewsItems() { Id = 8, Category = "Financial", Headline = "headline8", Subhead = "Sub8", Image = "none" });

            items.Add(new NewsItems() { Id = 9, Category = "Financial", Headline = "headline9", Subhead = "Sub9", Image = "none" });

            items.Add(new NewsItems() { Id = 10, Category = "Financial", Headline = "headline10", Subhead = "Sub10", Image = "none" });

            return items;
        }
    }
}
