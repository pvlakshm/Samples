using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeEx
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class NoteAttribute : TestPropertyAttribute
    {
        public NoteAttribute(string s)
            : base("Note", s)
        {
        }
    }
}
