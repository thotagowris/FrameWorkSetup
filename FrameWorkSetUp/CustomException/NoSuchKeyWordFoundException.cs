using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.CustomException
{
    public class NoSuchKeyWordFoundException : Exception
    {
        public NoSuchKeyWordFoundException(string msg) : base(msg)
        {

        }
    }
}
