namespace VVCyberAware.Methods
{
    public class CalculatingProcent
    {
        public int Calculation(int y, int x)
        {
            if (x != 0)
            {
                return (int)Math.Floor((y / (double)x) * 100);
            }
            else
            {
                return 0;
            }
        }
    }

}
