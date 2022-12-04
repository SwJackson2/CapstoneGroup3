using System;

namespace searchForProperty
{

    public class SearchHandler
    {
        User aUser = new User();
        public Search newPropertySearch(string street, string city, string state, string postcode)
        {
            return aUser.newPropertySearch(street, city, state, postcode);
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

        /// <summary>
        /// Creates a new Search Object
        /// </summary>
        public Search newPropertySearch(string street, string city, string state, string postcode)
        {
            return new Search(street, city, state, postcode);
        }
    }

    public class Search
    {
        private int number;
        private string street;
        private string city;
        private string state;
        private string postcode;

        public Search(string street, string city, string state, string postcode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.postcode = postcode;
        }


        /// <summary>
        /// What the user attempted search in the DB
        /// </summary>
        public void propertyQuery() { }

        /// <summary>
        /// Used to display a convert a screen to front end.
        /// </summary>
        public void displayProperty() { }
    }
    public class PropertyDB
    {
        private bool matchFound;

        /// <summary>
        /// Retrieves a specific advertisement from the DB
        /// </summary>
        /// <returns></returns>
        Advertisement getAdvertisement() {
            return new Advertisement();
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
        public Advertisement() { }
        public Advertisement(double price, string desc)
        {
            this.Price = price;
            this.Description = desc;
        }
    }
        public class AdvertisementAddress
    {
        private int advertisementID;
        private int Number;
        private string Street;
        private string City;
        private string State;
        private string PostCode;

        //AdvertisementAddress
        string getPostCode() { return PostCode; }
        string getCity() { return City; }
        string getStreet() { return Street; }

    }


}
