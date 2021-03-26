using System;
using System.Text;

namespace binary.Entities
{
    public class Binary
    {
        public int DecimalNumber { get; set; }
        public string BinaryNumber { get; set; }
        public double Sum { get; set; }
        public int Length { get; set; }
        public int? FirstTime { get; set; }

        public Binary(int decimalNumber)
        {
            DecimalNumber = decimalNumber;
            Sum = 0;
            Length = 0;
            FirstTime = null;
        }

        public Binary(string binaryNumber)
        {
            BinaryNumber = binaryNumber;
        }

        public string DecimalToBinary()
        {
            StringBuilder text = new StringBuilder();
            for(int i = 1024; i >= 0; i--)
            {
                if(i <= DecimalNumber)
                {
                    if(Math.Pow(2,i) + Sum <= DecimalNumber)
                    {
                        Sum += Math.Pow(2, i);
                        text.Append("1 ");
                        if(FirstTime == null)
                        {
                            FirstTime = 1;
                        }
                    }
                    else
                    {
                        if(FirstTime != null)
                        {
                            text.Append("0 ");
                        }
                    }
                }
            }
            return text.ToString();
        }

        public double BinaryToDecimal()
        {
            string[] digit = BinaryNumber.Split(' ');
            int size = digit.Length -1;
            int x = 0;

            for(int i = size; i >= 0; i--)
            {
                int number = int.Parse(digit[x]);
                if(number == 1)
                {
                    Sum += Math.Pow(2,i);
                }
                x++;
            }
            return Sum;
        }
    }
}