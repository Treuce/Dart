using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace DaRT.Helpers
{
    public class Ident
    {
        private static string _fingerPrint = string.Empty;
        public static string RandIdent = Ident.Value();

        private static string GetHexString(IList<byte> bt)
        {
            string str1 = string.Empty;
            for (int index = 0; index < bt.Count; ++index)
            {
                int num1 = (int)bt[index];
                int num2 = num1 & 15;
                int num3 = num1 >> 4 & 15;
                string str2 = num3 <= 9 ? str1 + num3.ToString((IFormatProvider)CultureInfo.InvariantCulture) : str1 + ((char)(num3 - 10 + 65)).ToString((IFormatProvider)CultureInfo.InvariantCulture);
                str1 = num2 <= 9 ? str2 + num2.ToString((IFormatProvider)CultureInfo.InvariantCulture) : str2 + ((char)(num2 - 10 + 65)).ToString((IFormatProvider)CultureInfo.InvariantCulture);
                if (index + 1 != bt.Count && (index + 1) % 2 == 0)
                    str1 += "-";
            }
            return str1;
        }

        private static string GetHash(string s)
        {
            return Ident.GetHexString((IList<byte>)new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(s)));
        }

        private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string str = "";
            var a = new ManagementClass(wmiClass);
            foreach (ManagementBaseObject instance in new ManagementClass(wmiClass).GetInstances())
            {
                if (!(instance[wmiMustBeTrue].ToString() != "True"))
                {
                    if (!(str != ""))
                    {
                        try
                        {
                            str = instance[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            return str;
        }

        private static string Identifier(string wmiClass, string wmiProperty)
        {
            string str = "";
            foreach (ManagementBaseObject instance in new ManagementClass(wmiClass).GetInstances())
            {
                if (!(str != ""))
                {
                    try
                    {
                        str = instance[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return str;
        }

        private static string CpuId()
        {
            string str1 = Ident.Identifier("Win32_Processor", "UniqueId");
            if (str1 != "")
                return str1;
            string str2 = Ident.Identifier("Win32_Processor", "ProcessorId");
            if (str2 != "")
                return str2;
            string str3 = Ident.Identifier("Win32_Processor", "Name");
            if (str3 == "")
                str3 = Ident.Identifier("Win32_Processor", "Manufacturer");
            return str3 + Ident.Identifier("Win32_Processor", "MaxClockSpeed");
        }

        private static string BiosId()
        {
            return Ident.Identifier("Win32_BIOS", "Manufacturer") + Ident.Identifier("Win32_BIOS", "SMBIOSBIOSVersion") + Ident.Identifier("Win32_BIOS", "IdentificationCode") + Ident.Identifier("Win32_BIOS", "SerialNumber") + Ident.Identifier("Win32_BIOS", "ReleaseDate") + Ident.Identifier("Win32_BIOS", "Version");
        }

        private static string DiskId()
        {
            return Ident.Identifier("Win32_DiskDrive", "Model") + Ident.Identifier("Win32_DiskDrive", "Manufacturer") + Ident.Identifier("Win32_DiskDrive", "Signature") + Ident.Identifier("Win32_DiskDrive", "TotalHeads");
        }

        private static string BaseId()
        {
            return Ident.Identifier("Win32_BaseBoard", "Model") + Ident.Identifier("Win32_BaseBoard", "Manufacturer") + Ident.Identifier("Win32_BaseBoard", "Name") + Ident.Identifier("Win32_BaseBoard", "SerialNumber");
        }

        private static string VideoId()
        {
            return Ident.Identifier("Win32_VideoController", "DriverVersion") + Ident.Identifier("Win32_VideoController", "Name");
        }

        private static string MacId()
        {
            return Ident.Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }

        private static string Value()
        {
            if (string.IsNullOrEmpty(Ident._fingerPrint))
                Ident._fingerPrint = Ident.GetHash("CPU >> " + Ident.CpuId() + "\nBIOS >> " + Ident.BiosId() + "\nBASE >> " + Ident.BaseId() + "\nDISK >> " + Ident.DiskId() + "\nVIDEO >> " + Ident.VideoId() + "\nMAC >> " + Ident.MacId());
            return Ident._fingerPrint;
        }
    }
}
