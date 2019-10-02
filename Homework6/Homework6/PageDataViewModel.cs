using System;
using System.Collections.Generic;

namespace Homework6
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(RelativeLayoutPage), "Relative Layout",
                                      "Explore XAML markup extensions"),
            };
        }

        public static IList<PageDataViewModel> All { private set; get; } 
    }
}
