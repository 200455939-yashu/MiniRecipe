using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using MiniRec.Models;
using Xamarin.Forms;

namespace MiniRec.ViewModels

{
    public class BrowsePageVM : GalaSoft.MvvmLight.ViewModelBase
	{



  //             public ObservableCollection<Category> _categorieslist = new ObservableCollection<Category>();
  //             public ObservableCollection<Category> CategoriesList
		//{
  //                     get { return _categorieslist; }
  //                     set { SetProperty(ref _categorieslist, value); }


         public BrowsePageVM()
        {
            GetData();
        }

        private IEnumerable<object> Data { set; get; }

        private async Task GetData()
        {

            //Initialize the Amazon Cognito credentials provider

                CognitoAWSCredentials credentials = new CognitoAWSCredentials(Shared.Constants.IdentityPoolID
                    , // Identity pool ID
                    RegionEndpoint.CACentral1 // Region
                );

            var dbClient = new Amazon.DynamoDBv2.AmazonDynamoDBClient(credentials, Amazon.RegionEndpoint.CACentral1);
            DynamoDBContext context = new DynamoDBContext(dbClient);

            await Task.Delay(1000);

            Task<Category> Data = context.LoadAsync<Category>(1);

            await Task.Delay(1000);
            Console.Write("DB Result data containss --->" + Data);

            //ScanResponse dbresult_scan_val = await dbClient.ScanAsync(new ScanRequest
            //{
            //    TableName = "Categories",
            //    AttributesToGet = new List<string> { "id", "Name" }
            //});

            //await Task.Delay(10000);

            //Data = dbResult[].Select(i => (
            //    id: i["id"].S,
            //    name: i["Name"].S
            //)).OrderBy(i => i.name);
            await Task.Delay(1000);
            RaisePropertyChanged(nameof(Data));

        }

  //      public BrowsePageVM() {
		//	CategoriesList = new ObservableCollection<Category>();
		//	CategoriesList.Add(new Category { Id = 0, Name = "Breakfast" });
		//	CategoriesList.Add(new Category { Id = 1, Name = "Lunch" });
		//	CategoriesList.Add(new Category { Id = 2, Name = "Dinner" });
		//	CategoriesList.Add(new Category { Id = 3, Name = "Dessert" });
		//}
	}
}
