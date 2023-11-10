namespace Exercise002
{
    public class Cube
    {
        int edgeLength;

        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }

        public override string ToString()
        {
            return "The length of the edge is "
                + this.edgeLength
                + " and the volume "
                + this.Volume();
        }
    }
}
