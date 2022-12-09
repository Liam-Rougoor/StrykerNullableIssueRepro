using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MySourceApp
{
    public class MyClass
    {
        public static bool MyMethod([NotNullWhen(true)] int myProp) 
        {
            return true;
        }
    }
}
