namespace addUser
{
    public class userHandler
    {
        User aUser;

        User createUser(string fName, string lName, string email, string pwd)
        {
            User oUser = new User(fName, lName, email, pwd);

            return oUser;
        }

        public void createUserAddress(int num, string street, string city, string state, string postcode)
        {
            aUser.createUserAddress(num, street, city, state, postcode);
        }
        void updateEmail() {
            aUser.updateEmail();
        }
        void updatePassword() {
            aUser.updatePassword();
                }
    }


    public class User
    {
        private int UserID;
        private string FirstName;
        private string LastName;
        private string Email;
        private string Password;    
        
        public User(string fName, string lName, string email, string pwd)
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
            Password = pwd;
        }

         public UserAddress createUserAddress(int num, string street, string city, string state, string postcode)
        {
            UserAddress oUserA = new UserAddress(num, street, city, state, postcode);

            return oUserA;
        }
        public void updateEmail() { }
        public void updatePassword() { }
    }

    public class UserAddress
    {
        private int UserID;
        private int Number;
        private string Street;
        private string City;
        private string State;
        private string PostCode;

        public UserAddress(int num, string street, string city, string state, string postcode)
        {
            Number = num;
            Street = street;
            City = city;
            State = state;
            PostCode = postcode;
                
        }
    }
}