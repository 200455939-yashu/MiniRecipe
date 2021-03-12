using System;
using System.Collections.Generic;
using MiniRec.Models;

namespace MiniRec.ViewModels {
	public class RecipeDetailsPageVM : ViewModelBase {
        private Recipe recipeModel;

        public string name { get; set; }
        public string description { get; set; }
        public float rating { get; set; }
        public List<String> instructionList { get; set; }
        public List<Ingredient> ingredientList { get; set; }
        public List<Category> categoryList { get; set; }

        public RecipeDetailsPageVM(Recipe recipe) {
            recipeModel = recipe;
            name = recipeModel.Name;
            description = recipeModel.Description;
            rating = recipeModel.Rating;
            instructionList = recipeModel.InstructionList;
            ingredientList = recipeModel.IngredientList;
            categoryList = recipeModel.CategoryList;
        }
    }
}
