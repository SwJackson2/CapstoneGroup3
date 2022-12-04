using System;

namespace postAdvert
{
    public class AdvertisementHandler
    {
        User aUser = new User();
        Advertisement aAdvertisement;

        public Advertisement createAdvertisement(double price, string desc)
        {
            aUser.createAdvertisement(price, desc);
            return aAdvertisement;
        }
    }

    public class User
    {
        private int UserID;
        private string FirstName;
        private string LastName;
        private string Email;
        private string Password;


        public User() { }


        public User(string fName, string lName, string email, string pwd)
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
            Password = pwd;
        }

        public Advertisement createAdvertisement(double price, string desc)
        {
            Advertisement oAdvertisement = new Advertisement(price, desc);
            return oAdvertisement;
        }
    }

    public class SystemAdmin
    {

        public void approveAdvertisement(Advertisement oAdvertisement) {
            oAdvertisement.aAdvertisementStatus.accepted = true;
        }
        public void rejectAdvertisementStatus(Advertisement oAdvertisement) {
            oAdvertisement.aAdvertisementStatus.rejected = true;
        }
        /// <summary>
        /// Will retreived Advertisements under review from the datatable
        /// </summary>
        public System.Data.DataTable getUnderReviewAds() {
            return new System.Data.DataTable();
        }

    }

    public class Advertisement
    {
        private int advertisementID;
        private double Price;
        private string Description;

        AdvertisementAddress aAdvertisementAddress;
        public AdvertisementStatus aAdvertisementStatus;
        Image aImage;
        public Advertisement(double price, string desc)
        {
            this.Price = price;
            this.Description = desc;
        }

        /// <summary>
        /// Will insert an AdvertisementAddress into the DB
        /// </summary>
        public void createAdvertisementAddress(int num, string street, string city, string state, string postcode)
        {
            aAdvertisementAddress = new AdvertisementAddress(num, street, city, state, postcode);
        }

        /// <summary>
        /// Will insert an AdvertisementStatus into the DB
        /// </summary>
        public void createAdvertisementStatus(bool accepted, bool rejected, bool underReview)
        {
            aAdvertisementStatus = new AdvertisementStatus(accepted, rejected, underReview);
        }

        /// <summary>
        /// Will insert an AdvertisementImg into the DB
        /// </summary>
        public void createAdvertisementImg(string type, Blob binaryContent) {
            aImage = new Image(type, binaryContent);
        }
    }



    public class AdvertisementAddress{
        private int advertisementID;
        private int number;
        private string street;
        private string city;
        private string state;
        private string postcode;


        public AdvertisementAddress(int number, string street, string city, string state, string postcode)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.state = state;
            this.postcode = postcode;
        }

        public string getPostCode() { return postcode; }
    }

    public class AdvertisementStatus
    {
        private int advertisementID;
        public bool accepted { get;set; }
        public bool rejected { get; set; }
        private bool underReview;

        public AdvertisementStatus(bool accepted, bool rejected, bool underReview)
        {
            this.accepted = accepted;
            this.rejected = rejected;
            this.underReview = underReview;
        }

        /// <summary>
        /// Return Accepted Advertisements
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable getAccepted() {
            return new System.Data.DataTable();
        }

        /// <summary>
        /// Returns Rejected Advertisements
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable getRejected() {
            return new System.Data.DataTable();
        }

        /// <summary>
        /// Returns Advertisments that are under review
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable getUnderReview() {
            return new System.Data.DataTable();
        }

    }

    public class Image
    {
        private int advertisement;
        private string imageType; //png, jpg, etc.
        private Blob binaryContent;

        public Image(string imageType, Blob binaryContent)
        {
            this.imageType = imageType;
            this.binaryContent = binaryContent;
        }
    }
}
