using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace ProcessMemoryTool
{
    /// <summary>
    /// ゲームプロセス
    /// </summary>
    public class ProcessMemory
    {
        Process proc;
        Memory memory;

        public ProcessMemory(Process p)
        {
            proc = p;
            memory = new Memory();
        }
        public Memory.MEMORY_BASIC_INFORMATION[] GetMemoryBasicInfos()
        {
            return memory.GetMemoryInfos(proc);
        }

        public Int32 ReadInt32(int address)
        {
            byte[] data = MemoryProvidor.ReadProcessMemory(proc.Handle, address, 4);
            return data[0] + data[1] * 0x100 + data[2] * 0x10000 + data[3] * 0x1000000;
        }

        public Int16 ReadInt16(int address)
        {
            byte[] data = MemoryProvidor.ReadProcessMemory(proc.Handle, address, 2);
            return (short)(data[0] + data[1] * 0x100);
        }

        public byte[] ReadBytes(int address, int size)
        {
            return MemoryProvidor.ReadProcessMemory(proc.Handle, address, size);
        }
    }
}
