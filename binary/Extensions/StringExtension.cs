namespace System
{
    public static class StringExtension
    {
        public static double BinaryToDecimal(this string obj)
        {
            string[] digit = obj.Split(' ');
            int size = digit.Length -1;
            int x = 0;
            double sum = 0;

            for(int i = size; i >= 0; i--)
            {
                int number = int.Parse(digit[x]);
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