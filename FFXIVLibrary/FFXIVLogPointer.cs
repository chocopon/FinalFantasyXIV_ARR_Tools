using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFXIV_Tools
{
    public struct FFXIVLogPointer
    {
        public IntPtr logCount;

        public IntPtr logIndext
        {
            get { return IntPtr.Add(logCount, 0x20); }
        }
        public IntPtr logEnt
        {
            get { return IntPtr.Add(logCount, 0x30); }
        }
        public IntPtr logCurrent
        {
            get { return IntPtr.Add(logCount, 0x34); }
        }
    }

    public partial class FFXIVLogMemoryInfo
    {
        internal static readonly List<int> CHATPTR = new List<int>
        {
            0xF875A8,
            0x18,
            0x200
        };

        internal FFXIVLogPointer GetChatLogPointer()
        {
            IntPtr res = ResolvePointerPath(CHATPTR);

            FFXIVLogPointer p = new FFXIVLogPointer();

            p.logCount = res;
            return p;
        }

        public IntPtr ResolvePointerPath(List<int> path)
        {
            IntPtr currentPtr = ffxiv.proc.MainModule.BaseAddress;
            IntPtr result = IntPtr.Zero;
            int count = path.Count;
            int i = 0;

            foreach (int pointer in path)
            {
                if (++i < count)
                {
                    currentPtr += pointer;
                    currentPtr = (IntPtr)ffxiv.ReadInt32((int)currentPtr);
                }
                else
                    result = currentPtr + pointer;
            }
            return result;
        }
    }

}
