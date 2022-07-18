using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;
using GoSecuri.Data;
using GoSecuri.Model;
using Newtonsoft.Json;

namespace GoSecuri.Controllers
{
    public class AuthentificationController : Controller
    {
        FirestoreDb database;
        UserDataModel user;
       public AuthentificationController(FirebaseConnection connection)
        {
            this.database = connection.database;
        }
        public async Task<bool> Connection(string password , string email)
        {
            DocumentReference usersRef = database.Collection("Users").Document(email);
            DocumentSnapshot snapshot = await usersRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {

                user = snapshot.ConvertTo<UserDataModel>();
                if (user.password == password)
                {
                    return true;
                }
                else return false;

            }
            else return false;

        }
        public async void AddUser(string email , string password)
        {

        }
    }
}
