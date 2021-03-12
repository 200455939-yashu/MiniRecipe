using System;
using System.Collections.ObjectModel;
using MiniRec.Models;
using Xamarin.Forms;

namespace MiniRec.ViewModels {
	public class BrowsePageVM : ViewModelBase {

		public ObservableCollection<Category> _categorieslist = new ObservableCollection<Category>();
		public ObservableCollection<Category> CategoriesList {
			get { return _categorieslist; }
			set { SetProperty(ref _categorieslist, value); }
		}

		public BrowsePageVM() {
			CategoriesList = new ObservableCollection<Category>();
			CategoriesList.Add(new Category { Id = 0, Name = "Breakfast" });
			CategoriesList.Add(new Category { Id = 1, Name = "Lunch" });
			CategoriesList.Add(new Category { Id = 2, Name = "Dinner" });
			CategoriesList.Add(new Category { Id = 3, Name = "Dessert" });
		}
	}
}
