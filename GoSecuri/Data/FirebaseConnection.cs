using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace GoSecuri.Data
{
    public class FirebaseConnection
    {
       public FirestoreDb database;
        public FirebaseConnection()
        {
            FirestoreClient client;
            FirestoreClientBuilder builder= new FirestoreClientBuilder();
            builder.CredentialsPath =   Path.GetFullPath("./wwwroot/gosecuri-856f6-firebase-adminsdk-vbx74-85f10429f4.json");
            client = builder.Build();
            database = FirestoreDb.Create("gosecuri-856f6",client);
        }

     
    }
}

