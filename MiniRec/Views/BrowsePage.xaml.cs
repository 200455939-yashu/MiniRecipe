﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiniRec.ViewModels;
using System.Diagnostics;
using System.Linq;
using MiniRec.Models;

namespace MiniRec.Views {
	public partial class BrowsePage : ContentPage {


        public BrowsePage()
        {
            BindingContext = new BrowsePageVM();
            InitializeComponent();
            //ContentPage = new BrowsePage() { BindingContext = new BrowsePageVM()}

        }

        public BrowsePage ContentPage { get; set; }

        void collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e) {
			if(collectionList.SelectedItem == null) return;

			var categoryObject = (e.CurrentSelection.FirstOrDefault() as Category);

			if(categoryObject != null) {

				string current = categoryObject.Name;

				Debug.WriteLine($"current selected category:{current}");
			}

			//collectionList.SelectedItem = null;
		}
	}
}
