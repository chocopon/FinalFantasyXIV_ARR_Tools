using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ProcessMemoryTool
{
    public class MemoryProvidor
    {
        /// <summary>
        /// ポインタ型を使わないメソッド : Marshal.PtrTo*をつかってがんばれ
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="addr"></param>
        /// <param name="OutputBuffer"></param>
        /// <param name="nBufferSize"></param>
        /// <param name="lpNumberOfBytesRead"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public extern static bool ReadProcessMemorySafe(IntPtr handle, IntPtr addr, IntPtr OutputBuffer, UIntPtr nBufferSize, out UIntPtr lpNumberOfBytesRead);


        [DllImport("kernel32.dll")]
        private static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);


        public static byte[] ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, int size)
        {
            byte[] buffer = new byte[size];
            IntPtr a;
            ReadProcessMemory(hProcess, (IntPtr)lpBaseAddress, buffer, (uint)size, out a);
            return buffer;
        }

        public static IntPtr ReadProcessMemorySafe(IntPtr Handle, IntPtr Address, uint nBytesToRead)
        {
            IntPtr Buffer = Marshal.AllocHGlobal((int)nBytesToRead);
            UIntPtr BytesRead = UIntPtr.Zero;
            UIntPtr BytesToRead = (UIntPtr)nBytesToRead;
            if (!ReadProcessMemorySafe(Handle, Address, Buffer, BytesToRead, out BytesRead))
            {
                return IntPtr.Zero;
            }
            return Buffer;
        }

        public static int ReadMemoryInt32(IntPtr handle, IntPtr addr)
        {
            IntPtr Buffer = IntPtr.Zero;
            int i = 0;
            Buffer = ReadProcessMemorySafe(handle, addr, 4);
            try
            {
                i = Marshal.ReadInt32(Buffer);
            }
            finally
            {
                Marshal.FreeHGlobal(Buffer);
            }
            return i;
        }

        public static Single ReadMemorySingle(IntPtr handle, IntPtr addr)
        {
            byte[] Buffer = new Byte[4];
            Single i = 0;
            Buffer = ReadProcessMemory(handle, (int)addr, 4);
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(Buffer);
                System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
                i = br.ReadSingle();
            }
            finally
            {
            }
            return i;
        }

        public static int ReadMemoryInt16(IntPtr handle, IntPtr addr)
        {
            IntPtr Buffer = IntPtr.Zero;
            int i = 0;
            Buffer = ReadProcessMemorySafe(handle, addr, 2);
            try
            {
                i = Marshal.ReadInt16(Buffer);
            }
            finally
            {
                Marshal.FreeHGlobal(Buffer);
            }
            return i;
        }

        public static Process GetFFXIVGameProcess()
        {
            Process[] procs = Process.GetProcessesByName("ffxiv");
            if (procs.Length > 0)
                return procs[0];
            return null;
        }

    }
}