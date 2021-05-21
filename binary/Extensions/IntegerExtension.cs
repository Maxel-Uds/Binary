using System.Text;

namespace System
{
    public static class IntegerExtension
    {
        public static string DecimalToBinary(this int obj)
        {
            StringBuilder text = new StringBuilder();
            double sum = 0;
            int? firstTime = null;
            
            for(int i = 1024; i >= 0; i--)
            {
                if(i <= obj)
                {
                    if(Math.Pow(2,i) + sum <= obj)
                    {
                        sum += Math.Pow(2, i);
                        text.Append("1");
                        if(firstTime == null)
                        {
                            firstTime = 1;
                        }
                    }
                    else
                    {
                        if(firstTime != null)
                        {
                            text.Append("0");
                        }
                    }
                }
            }
            return text.ToString();
        }
    }
}