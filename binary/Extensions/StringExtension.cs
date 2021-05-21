namespace System
{
    public static class StringExtension
    {
        public static double BinaryToDecimal(this string obj)
        {
            int x = 0;
            double sum = 0;

            for(int i = (obj.Length - 1); i >= 0; i--)
            {
                double number = Char.GetNumericValue(obj[x]);
                if(number == 1)
                {
                    sum += Math.Pow(2,i);
                }
                x++;
            }
            return sum;
        }
    }
}