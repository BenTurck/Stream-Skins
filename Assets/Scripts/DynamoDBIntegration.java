//Integrating Amazon DynamoDB

{ 
"Statement": [{
    "Effect": "Allow", //gives permissions for database
    "Action": [
        "dynamodb:DeleteItem",
        "dynamodb:GetItem",
        "dynamodb:PutItem",
        "dynamodb:Scan",
        "dynamodb:UpdateItem"
        ],
    "Resource": "arn:aws:dynamodb:us-east-2:330789948177:table/User"
  }]
}
//creating client
var credentials = new CognitoAWSCredentials(ID, RegionEndpoint.USEast1);  //IDENTITY_POOL_ID
AmazonDynamoDBClient client = new AmazonDynamoDBClient(credentials);
DynamoDBContext Context = new DynamoDBContext(client);

/*
Return Information from table
*/

resultText.text +=(" Retrieving table information:   ");

       var request = new DescribeTableRequest { TableName = @"ProductCatalog" };
       Client.DescribeTableAsync(request, (result) => {
               if (result.Exception != null) {
                       resultText.text += result.Exception.Message;
                       Debug.Log(result.Exception);
                       return;
               }
              var response = result.Response;
              TableDescription description = response.Table;
              resultText.text += ("TableName: " + description.TableName + "\n");
              resultText.text += ("Items Within Database: " + description.ItemCount + "\n");
       }, null);
   }
   
/*
  METHOD TO SAVE AN OBJECT
*/

[DynamoDBTable("UserRecords")]
    public class User {
        [DynamoDBHashKey]   //ID Hash Key to recieve the rest of the data.
        public int ID { 
            get;
            set; 
        }
        
        [DynamoDBProperty]
        public string Email { 
            get;
            set; 
        }
        
        [DynamoDBProperty]
        public string UserName { 
            get;
            set; 
        }
        
        [DynamoDBProperty]
        public string EncryptedPassword { 
            get; 
            set; 
        }
    }
    
//CREATE NEW USER
private void createNewUser() {
    User myUser = new User {
        ID = UserID,
        Email = "Bob12345@yahoo.com",
        UserName = "Bob12345",
        EncryptedPassword = "!&#*!(BE",
    };
    // Save the user.
    Context.SaveAsync(myUser,(result)=> {
        if(result.Exception == (null) ) {
            resultText.text += @"User Saved";
        }
    });
}

//retrieve method needed
//Update method needed
//delete user method needed
