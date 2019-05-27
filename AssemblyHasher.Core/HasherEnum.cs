using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyHasher.Core
{
    /// <summary>
    /// 动态选择运算方式
    /// </summary>
    public enum HasherEnum
    {
        None=1,
        Default=2,
        IlHasher=3
    }
}
