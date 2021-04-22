using System;
using System.Collections.Generic;
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

		public ObservableCollection<Recipe> _allRecipeList = new ObservableCollection<Recipe>();
		public ObservableCollection<Recipe> AllRecipeList {
			get { return _allRecipeList; }
			set { SetProperty(ref _allRecipeList, value); }
		}

		public BrowsePageVM() {
			CategoriesList = new ObservableCollection<Category>();
			CategoriesList.Add(new Category { Id = 0, Name = "Breakfast" });
			CategoriesList.Add(new Category { Id = 1, Name = "Lunch" });
			CategoriesList.Add(new Category { Id = 2, Name = "Dinner" });
			CategoriesList.Add(new Category { Id = 3, Name = "Dessert" });


			AllRecipeList = new ObservableCollection<Recipe>();
			AllRecipeList.Add(new Recipe {
				Id = 0,
				Name = "Spaghetti Bolognese",
				Rating = 4.5f,
				ImageUrl = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Noodles.jpg",
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
				},
				CategoryList = new List<Category> {
					new Category { Id = 1, Name = "Lunch"},
					new Category { Id = 2, Name = "Dinner"}
				}
			});

			AllRecipeList.Add(new Recipe {
				Id = 1,
				Name = "Carbonara",
				Rating = 4.2f,
				ImageUrl = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Carbonara.jpg",
				InstructionList = new List<String> {
						"1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
						"3. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
				},
				IngredientList = new List<Ingredient> {
						new Ingredient {Name = "ham", Quantity = 0.5f, Unit = "lb"},
						new Ingredient {Name = "onion", Quantity = 1, Unit = ""},
						new Ingredient {Name = "egg", Quantity = 2, Unit = ""}
				},
				CategoryList = new List<Category> {
					new Category { Id = 1, Name = "Lunch"},
					new Category { Id = 2, Name = "Dinner"}
				}
			}); ;

			AllRecipeList.Add(new Recipe {
				Id = 2,
				Name = "Onion Soup",
				Rating = 3.5f,
				ImageUrl = "https://minirecphotos.s3.ca-central-1.amazonaws.com/FoodImages/Carbonara.jpg",
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
				},
				CategoryList = new List<Category> {
					new Category { Id = 0, Name = "Breakfast"},
					new Category { Id = 1, Name = "Lunch"},
					new Category { Id = 2, Name = "Dinner"}
				}
			});
		}
	}
}
