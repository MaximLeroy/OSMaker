using System;
using System.Drawing;

namespace OSMaker.Host
{
    /// <summary>
    /// Generated random color. It is used by MyRootDesigner
    /// </summary>
    public class RandomUtil
    {
        internal const int MaxRGBInt = 255;
        private static Random rand = null;

        public RandomUtil()
        {
            if (rand is null)
                InitializeRandoms(new Random().Next());
        }

        private void InitializeRandoms(int seed)
        {
            rand = new Random(seed);
        }

        public virtual Color GetColor()
        {
            byte rval, gval, bval;
            rval = (byte)GetRange(0, MaxRGBInt);
            gval = (byte)GetRange(0, MaxRGBInt);
            bval = (byte)GetRange(0, MaxRGBInt);
            var c = Color.FromArgb(rval, gval, bval);
            return c;
        }

        public int GetRange(int nMin, int nMax)
        {
            // Swap max and min if min > max
            if (nMin > nMax)
            {
                int nTemp = nMin;
                nMin = nMax;
                nMax = nTemp;
            }

            if (nMax != int.MaxValue)
                System.Threading.Interlocked.Increment(ref nMax);
            int retVal = rand.Next(nMin, nMax);
            return retVal;
        }
    }
}