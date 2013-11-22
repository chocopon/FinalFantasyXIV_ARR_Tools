using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ProcessMemoryTool
{
    public class Memory
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            internal PROCESSOR_INFO_UNION p;
            public uint dwPageSize;
            public uint lpMinimumApplicationAddress;
            public uint lpMaximumApplicationAddress;
            public uint dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public uint wProcessorLevel;
            public uint wProcessorRevision;
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct PROCESSOR_INFO_UNION
        {
            [FieldOffset(0)]
            internal uint dwOemId;
            [FieldOffset(0)]
            internal ushort wProcessorArchitecture;
            [FieldOffset(2)]
            internal ushort wReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public UIntPtr BaseAddress;
            public UIntPtr AllocationBase;
            public MEMORY_ALLOCATION_PROTECT AllocationProtect;
            public IntPtr RegionSize;
            public MEMORY_STATE State;
            public MEMORY_ALLOCATION_PROTECT Protect;
            public uint Type;
        }

        /// <summary>
        /// The state of the pages in the region. This member can be one of the following values.
        /// </summary>
        public enum MEMORY_STATE:uint
        {
            MEM_COMMIT =0x1000,
            MEM_FREE =0x10000,
            MEM_RESERVE = 0x2000
        }

        public enum MEMORY_TYPE : uint
        {
            /// <summary>
            /// Indicates that the memory pages within the region are mapped into the view of an image section.
            /// </summary>
            MEM_IMAGE = 0x1000000,
            /// <summary>
            /// Indicates that the memory pages within the region are mapped into the view of a section.
            /// </summary>
            MEM_MAPPED = 0x40000,
            /// <summary>
            /// Indicates that the memory pages within the region are private (that is, not shared by other processes).
            /// </summary>
            MEM_PRIVATE =0x20000,
        }

        public enum MEMORY_ALLOCATION_PROTECT:uint
        {
            PAGE_EXECUTE =0x10,
            PAGE_EXECUTE_READ =0x20,
            PAGE_EXECUTE_READWRITE =0x40,
            PAGE_EXECUTE_WRITECOPY =0x80,
            PAGE_NOACCESS =0x01,
            PAGE_READONLY =0x02,
            PAGE_READWRITE =0x04,
            PAGE_WRITECOPY =0x08,
            PAGE_GUARD =0x100,
            PAGE_NOCACHE =0x200,
            PAGE_WRITECOMBINE = 0x400,

        }

        SYSTEM_INFO system_info;
        MEMORY_BASIC_INFORMATION mbi;

        [DllImport("kernel32.dll")]
        private static extern int VirtualQuery(ref uint lpAddress,
            ref MEMORY_BASIC_INFORMATION lpBuffer,
            int dwLength
        );

        [DllImport("kernel32.dll")]
        static extern int VirtualQueryEx(IntPtr hProcess, uint lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

        [DllImport("kernel32.dll")]
        private static extern void GetSystemInfo(
            [MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo
        );

        public Memory()
        {
            system_info = new SYSTEM_INFO();
            mbi = new MEMORY_BASIC_INFORMATION();
        }

        public void ShowMemory()
        {
            GetSystemInfo(ref system_info);
            Console.WriteLine("dwProcessorType: {0}", system_info.dwProcessorType.ToString());
            Console.WriteLine("dwPageSize: {0}", system_info.dwPageSize.ToString());

            if (VirtualQuery(ref system_info.dwPageSize,
                ref mbi,
                (int)System.Runtime.InteropServices.Marshal.SizeOf(mbi)) != 0
            )
            {
                Console.WriteLine("AllocationBase: {0}", mbi.AllocationBase);
                Console.WriteLine("BaseAddress: {0}", mbi.BaseAddress);
                Console.WriteLine("RegionSize: {0}", mbi.RegionSize);
            }
            else
            {
                Console.WriteLine("ERROR: VirtualQuery() failed.");
            }
        }

        public MEMORY_BASIC_INFORMATION[] GetMemoryInfos(Process proc)
        {
            GetSystemInfo(ref system_info);
            uint address = system_info.lpMinimumApplicationAddress;
            MEMORY_BASIC_INFORMATION mbi = new MEMORY_BASIC_INFORMATION();
            List<MEMORY_BASIC_INFORMATION> mList = new List<MEMORY_BASIC_INFORMATION>();
            while (address < system_info.lpMaximumApplicationAddress)
            {
                VirtualQueryEx(proc.Handle, address, out mbi, Marshal.SizeOf(mbi));

                mList.Add(mbi);
                address = (uint)mbi.BaseAddress + (uint)mbi.RegionSize;
            }
            return mList.ToArray();
        }

        public void ShowMemory(Process proc)
        {
            GetSystemInfo(ref system_info);
            uint address = system_info.lpMinimumApplicationAddress;
            MEMORY_BASIC_INFORMATION mbi = new MEMORY_BASIC_INFORMATION();
            while (address < system_info.lpMaximumApplicationAddress)
            {
                VirtualQueryEx(proc.Handle, address, out mbi, Marshal.SizeOf(mbi));

                Console.WriteLine("{0} {1}",((uint)mbi.BaseAddress).ToString("X"), mbi.RegionSize.ToString("X"));
                address = (uint)mbi.BaseAddress + (uint)mbi.RegionSize;
            }
        }
    }
}