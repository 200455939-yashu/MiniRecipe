using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MiniRec.Models;
using MiniRec.ViewModels;
using Xamarin.Forms;

namespace MiniRec.Views {
	public partial class RecipeDetailsPage : ContentPage {
		public RecipeDetailsPage(Recipe recipe) {
            BindingContext = new RecipeDetailsPageVM(recipe);
			InitializeComponent();
		}
	}
}
