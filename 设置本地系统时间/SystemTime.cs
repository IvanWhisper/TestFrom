using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 设置本地系统时间
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
   public class SystemTime
    {
        public ushort vYear;
        public ushort vMonth;
        public ushort vDayOfWeek;
        public ushort vDay;
        public ushort vHour;
        public ushort vMinute;
        public ushort vSecond;
    }
    public class SetSystemDateTime
    {
        [DllImportAttribute("Kernel32.dll")]
        public static extern void GetLocalTime(SystemTime st);
        [DllImportAttribute("Kernel32.dll")]
        public static extern void SetLocalTime(SystemTime st);
    }
}

