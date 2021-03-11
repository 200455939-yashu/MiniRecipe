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
			CategoriesList.Add(new Category { Name = "Breakfast" });
			CategoriesList.Add(new Category { Name = "Lunch" });
			CategoriesList.Add(new Category { Name = "Dinner" });
			CategoriesList.Add(new Category { Name = "Dessert" });
		}
	}
}
