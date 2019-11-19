using System;
using System.Collections.Generic;
using System.Text;

namespace Zork.Common
{
    public interface IOutputService
    {
        void WriteLine(string value);

        void Writeline(object value);

        void Write(string value);

        void Write(object value);

        void Clear();
    }
}
