﻿using System;

namespace RobotQQ.Core
{
    /// <summary>
    /// 返回类型
    /// </summary>
    [Serializable]
    public enum ResultType
    {
        /// <summary>
        /// 表示只返回字符串 只有Html有数据
        /// </summary>
        String,
        /// <summary>
        /// 表示返回字符串和字节流 ResultByte和Html都有数据返回
        /// </summary>
        Byte
    }
}
