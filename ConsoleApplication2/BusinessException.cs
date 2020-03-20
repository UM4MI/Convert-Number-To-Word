using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class BusinessException
    {
        public String stringNumber { get; set; }
        public String stringDecimalNumber { get; set; }
    }

    [Serializable]
    class InvalidInputNumberException : Exception
    {
        public InvalidInputNumberException()
        {

        }

        public InvalidInputNumberException(string name)
            : base(String.Format("Invalid Dollar Value", name))
        {

        }

    }
    [Serializable]
    class InvalidInputNumberDecimalException : Exception
    {
        public InvalidInputNumberDecimalException()
            : base(String.Format("Invalid Cent Value"))
        {

        }

        public InvalidInputNumberDecimalException(string name)
            : base(String.Format("Invalid Cent Value", name))
        {

        }

    }

    [Serializable]
    class NumberOverflowException : Exception
    {
        public NumberOverflowException()
        {

        }

        public NumberOverflowException(string name)
            : base(String.Format("Maximum Input 37 Characters", name))
        {

        }

    }
    [Serializable]
    class InvalidInputSeparatorException : Exception
    {
        public InvalidInputSeparatorException()
            : base(String.Format("Invalid Separator Cent"))
        {

        }

        public InvalidInputSeparatorException(string name)
            : base(String.Format("Invalid Separator Cent", name))
        {

        }

    }
}
