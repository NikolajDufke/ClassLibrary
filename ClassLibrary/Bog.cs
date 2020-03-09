using System;

namespace ClassLibrary
{
    public class Bog
    {
        private string _forfatter;
        private int _sideTal;
        private string _isbn13;
        private string _title;

        public Bog(string title, string forfatter, int sideTal, string isbn13)
        {
            if (MinimumForfatterStringLenghtCheck(forfatter))
                _forfatter = forfatter;

            if (MaximumSideIntSize(sideTal) && MinumumSideIntSize(sideTal))
                _sideTal = sideTal;

            if(MinimumISBNStringLenghtCheck(isbn13))
            _isbn13 = isbn13;

            _title = title;
        }

        /// <summary>
        /// Bogens title
        /// </summary>
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        /// <summary>
        /// Bogens forfatter.
        /// </summary>
        public string Forfatter


        {
            get => _forfatter;
            set
            {
                if (MinimumForfatterStringLenghtCheck(value))
                    _forfatter = value;
            }
        }


        /// <summary>
        /// Antallet af sider i bogen
        /// </summary>
        public int SideTal
        {
            get => _sideTal;
            set
            {
                if (MaximumSideIntSize(value) && MinumumSideIntSize(value))
                    _sideTal = value;
            }
        }

        public string ISBN13
        {
            get => _isbn13;
            set
            {
                if(MinimumISBNStringLenghtCheck(value))
                _isbn13 = value;
            }
        }

        private bool MinimumISBNStringLenghtCheck(string value)
        {
            if (value.Length == 13)
            {
                return true;
            }

            throw new ArgumentOutOfRangeException("ISBN skal være 13 karaktere");
        }

        private bool MinimumForfatterStringLenghtCheck(string value)
        {
            if (value.Length >= 2)
            {
                return true;
            }

            throw new ArgumentOutOfRangeException("Forfatter skal indeholde mere en 2 karaktere");
        }

        private bool MinumumSideIntSize(int value)
        {
            if (value >= 4)
            {
                return true;
            }

            throw new ArgumentOutOfRangeException("Bogen kan ikke være mindre end 4 sider");
        }

        private bool MaximumSideIntSize(int value)
        {
            if (value <= 1000)
            {
                return true;
            }

            throw new ArgumentOutOfRangeException("Bogen kan ikke være mere end 1000 sider.");
        }
    }


}



