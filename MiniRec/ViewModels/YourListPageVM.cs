using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MiniRec.Models;
using Xamarin.Forms;

namespace MiniRec.ViewModels {
	public class YourListPageVM : ViewModelBase {

		public ObservableCollection<Recipe> _yourRecipeList =
			new ObservableCollection<Recipe>();
		public ObservableCollection<Recipe> YourRecipeList {
			get { return _yourRecipeList; }
			set { SetProperty(ref _yourRecipeList, value); }
		}

		public YourListPageVM() {
			YourRecipeList = new ObservableCollection<Recipe>();
			YourRecipeList.Add(new Recipe {
				Id = 0,
				Name = "Spaghetti Bolognese",
				Rating = 4.5f,
				image_url = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Noodles.jpg",
				InstructionList = new List<String> {
						"1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"5. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
				},
				IngredientList = new List<Ingredient> {
						new Ingredient {Name = "ground beef", Quantity = 1, Unit = "lb"},
						new Ingredient {Name = "onion", Quantity = 1, Unit = ""},
						new Ingredient {Name = "tomato paste", Quantity = 2, Unit = "tbsp"}
				}
			});

			YourRecipeList.Add(new Recipe {
				Id = 1,
				Name = "Carbonara",
				Rating = 4.2f,
				image_url = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Carbonara.jpg",
				InstructionList = new List<String> {
						"1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"3. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
				},
				IngredientList = new List<Ingredient> {
						new Ingredient {Name = "ham", Quantity = 0.5f, Unit = "lb"},
						new Ingredient {Name = "onion", Quantity = 1, Unit = ""},
						new Ingredient {Name = "egg", Quantity = 2, Unit = ""}
				}
			}); ;

			YourRecipeList.Add(new Recipe {
				Id = 2,
				Name = "Onion Soup",
				Rating = 3.5f,
				image_url = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Carbonara.jpg",
				InstructionList = new List<String> {
						"1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"4. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
				},
				IngredientList = new List<Ingredient> {
						new Ingredient {Name = "water", Quantity = 4, Unit = "cup"},
						new Ingredient {Name = "onion", Quantity = 1, Unit = ""},
						new Ingredient {Name = "salt", Quantity = 2, Unit = "tbsp"}
				}
			});
		}
	}
}
