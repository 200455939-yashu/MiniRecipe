using System;
using Amazon.DynamoDBv2.DataModel;

namespace MiniRec.Models {
    [DynamoDBTable("Categories")]
    public class Category {
        [DynamoDBHashKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
