namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override bool Equals(object song)
        {
            if (this == song)
            {
                return true;
            }
            if ((song == null) || !this.GetType().Equals(song.GetType()))
            {
                return false;
            }
            Song comparedSong = (Song)song;

            // if the values of the object variables are the same, the objects are equal
            if (
                this.name == comparedSong.name
                && this.artist == comparedSong.artist
                && this.durationInSeconds == comparedSong.durationInSeconds
            )
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }
    }
}
