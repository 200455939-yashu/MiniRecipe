using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
//using MiniRec.Models;

namespace MiniRec.ViewModels
{
    public class MainPageVM : ViewModelBase
    {
        public ObservableCollection<String> _categorieslist = new ObservableCollection<String>();
        public ObservableCollection<String> CategoriesList
        {
            get { return _categorieslist; }
            set { SetProperty(ref _categorieslist, value); }
        }

        public MainPageVM()
        {
            CategoriesList = new ObservableCollection<String>();
            CategoriesList.Add("Breakfast");
            CategoriesList.Add("Lunch");
            CategoriesList.Add("Dinner");
            CategoriesList.Add("Dessert");
        }
    }
}
