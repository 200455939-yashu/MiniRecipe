using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MiniRec.Models;

namespace MiniRec.ViewModels
{
    public class MainPageVM : ViewModelBase
    {
        public ObservableCollection<Category> _categorieslist = new ObservableCollection<Category>();
        public ObservableCollection<Category> CategoriesList
        {
            get { return _categorieslist; }
            set { SetProperty(ref _categorieslist, value); }
        }

        public MainPageVM()
        {
            CategoriesList = new ObservableCollection<Category>();
            CategoriesList.Add(new Category { Name = "Breakfast" });
            CategoriesList.Add(new Category { Name = "Lunch" });
            CategoriesList.Add(new Category { Name = "Dinner" });
            CategoriesList.Add(new Category { Name = "Dessert" });
        }
    }
}
