using System;
using System.Collections.Generic;

namespace CppSharp
{
    /// <summary>
    /// Represents a C++ property.
    /// </summary>
    public class Property : Declaration
    {
        public Property()
        {

        }

        public Type Type
        {
            get;
            set;
        }

        public Method GetMethod
        {
            get;
            set;
        }

        public Method SetMethod
        {
            get;
            set;
        }

        public override T Visit<T>(IDeclVisitor<T> visitor)
        {
            return visitor.VisitProperty(this);
        }
    }
}