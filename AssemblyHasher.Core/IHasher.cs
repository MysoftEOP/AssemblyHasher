using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyHasher.Core
{
    public interface IHasher
    {
        string GetHash(string sourcePath);
    }
}
