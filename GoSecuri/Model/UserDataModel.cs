
using Google.Cloud.Firestore;

namespace GoSecuri.Model
{
    [FirestoreData]
    public class UserDataModel
    {
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
    }
}
