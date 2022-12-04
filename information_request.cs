namespace informationRequestC
{
    public class InformationRequestHandler
    {
        User aUser; InformationRequest aInfoReq;
        public void createInfoRequest(string FN, string LN, string Email, string PN, string MSG)
        {
            aInfoReq = aUser.createInfoRequest(num, street, city, state, postcode);
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

         public informationRequest createInfoRequest(string FN, string LN, string Email, string PN, string MSG)
        {
            informationRequest oInfoReq = new informationRequest(FN, LN, Email, PN, MSG);
            return oUserA;
        }
    }

    public class informationRequest
    {
        private int infoRequestID;
        private string FirstName;
        private string LastName;
        private string Email;
        private string PhoneNumber;
        private string Message;

        public informationRequest(string FirstName, string LastName, string Email, string PhoneNumber, string Message)
        {
            FirstName = FN;
            LastName = LN;
            Email = Email;
            PhoneNumber = PN;
            Message = MSG;
        }
    }
}