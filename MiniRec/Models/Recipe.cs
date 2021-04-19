using System;
using System.Collections.Generic;

namespace MiniRec.Models {
	public class Recipe {

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public float Rating { get; set; }
		public string ImageUrl { get; set; }
		public List<String> InstructionList { get; set; }
		public List<Ingredient> IngredientList { get; set; }
		public List<Category> CategoryList { get; set; }
	}
}
