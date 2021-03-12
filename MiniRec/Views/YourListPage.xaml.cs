using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MiniRec.Models;
using MiniRec.ViewModels;
using Xamarin.Forms;

namespace MiniRec.Views {
	public partial class YourListPage : ContentPage {
		public YourListPage() {
			BindingContext = new YourListPageVM();
			InitializeComponent();
		}

        void collectionList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            if(collectionList.SelectedItem == null) return;

            var recipeObject = (e.CurrentSelection.FirstOrDefault() as Recipe);

            if(recipeObject != null) {

                string current = recipeObject.Name;

                Debug.WriteLine($"current selected recipe: {current}");

                var newPage = new RecipeDetailsPage(recipe: recipeObject);
                Navigation.PushAsync(newPage);
            }

            collectionList.SelectedItem = null;
        }
    }


}
