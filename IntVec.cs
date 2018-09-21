public class IntVec
    // Test Class to describe an long integer based vetor with various ascociated operations.
    // If a value of one represents a nanometer, then the maximum +- length is 0.5 Light minute.
    // Hence a cube could be constructed to the prescision of a nanometer with side lengths of
    // one light minute.  In ordinary language, from the diameter of DNA to ten times the
    // radius of the sun.
    {
        private long x;
        private long y;
        private long z;

        public IntVec(long xin, long yin, long zin)
        // Initialises the object from the input values
        {
            x = xin;
            y = yin;
            z = zin;
        }

        public void Print()
        // Prints the object
        {
            var strx = x.ToString();
            var stry = y.ToString();
            var strz = z.ToString();

            // calculates maximum string length
            var lenlist = new int[] {strx.Length, stry.Length, strz.Length};
            var maxlen = lenlist.Max();

            // adds spaces for neatness
            var xpad = "";
            var xcount = 0;
            while (xcount < maxlen-strx.Length)
            {
                xpad += " ";
                xcount += 1;
            }
            strx = xpad+strx;

            var ypad = "";
            var ycount = 0;
            while (ycount < maxlen-stry.Length)
            {
                ypad += " ";
                ycount += 1;
            }
            stry = ypad+stry;

            var zpad = "";
            var zcount = 0;
            while (zcount < maxlen-strz.Length)
            {
                zpad += " ";
                zcount += 1;
            }
            strz = zpad+strz;
            
            Console.WriteLine("\n⎡ "+strx+" ⎤\n⎢ "+stry+" ⎥\n⎣ "+strz+" ⎦");
        }
    }
