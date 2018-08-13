using System;

namespace Quest
{
    class Qst : ICloneable
    {
        private String _name;
        private String _description;
        private Int32 _minPlayers, _maxPlayers;
        private Int32 _maxTime;
        private Int32 _minPrice, _maxPrice;
        private Int32 _difficultyLevel;
        private Int32 _levelOfFear;
        private Int32 _minAge;
        private Double _rating;
        private String _nameOfTheOrganizer;

        public Object Clone()
        {
            Qst nqst = new Qst();
            nqst.Description = Description;
            nqst.DifficultyLevel = DifficultyLevel;
            nqst.LevelOfFear = LevelOfFear;
            nqst.MaxPlayers = MaxPlayers;
            nqst.MaxPrice = MaxPrice;
            nqst.MaxTime = MaxTime;
            nqst.MinAge = MinAge;
            nqst.MinPlayers = MinPlayers;
            nqst.MinPrice = MinPrice;
            nqst.Name = Name;
            nqst.NameOfTheOrganizer = NameOfTheOrganizer;
            nqst.Rating = Rating;
            return nqst;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public String NameOfTheOrganizer
        {
            get { return _nameOfTheOrganizer; }
            set { _nameOfTheOrganizer = value; }
        }
        public Int32 MinPlayers
        {
            get { return _minPlayers; }
            set { _minPlayers = value; }
        }
        public Int32 MaxPlayers
        {
            get { return _maxPlayers; }
            set { _maxPlayers = value; }
        }
        public Int32 MaxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; }
        }
        public Int32 MinPrice
        {
            get { return _minPrice; }
            set { _minPrice = value; }
        }
        public Int32 MaxPrice
        {
            get { return _maxPrice; }
            set { _maxPrice = value; }
        }
        public Int32 DifficultyLevel
        {
            get { return _difficultyLevel; }
            set { _difficultyLevel = value; }
        }
        public Int32 LevelOfFear
        {
            get { return _levelOfFear; }
            set { _levelOfFear = value; }
        }
        public Int32 MinAge
        {
            get { return _minAge; }
            set { _minAge = value; }
        }
        public Double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ NameOfTheOrganizer.GetHashCode();
        }

        public override string ToString()
        {
            return Name + "(" + NameOfTheOrganizer + ") : \n Rating : " + Rating + "\n" + Description + "\n Players : " + MinPlayers + " - " +
                   MaxPlayers + "\n Time : " + MaxTime + "\n Price : " + MinPrice + " - " + MaxPrice +
                   "\n Difficulty : " + DifficultyLevel + "\n Level Of fear : " + LevelOfFear + "\n Min Age : " +
                   MinAge;
        }
    }
}
