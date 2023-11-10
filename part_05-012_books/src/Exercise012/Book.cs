namespace Exercise012
{
    public class Book
    {
        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                Book comparedBook = (Book)compared;
                return this.name.Equals(comparedBook.name)
                    && this.publicationYear.Equals(comparedBook.publicationYear);
            }
            return false;
        }
    }
}
