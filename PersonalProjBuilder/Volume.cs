using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Volume
{

    public class GetVol
    {
        [DllImport("kernel32.dll")]
        private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, 
            UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, 
            ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);
        /// <summary>
        /// Get Volume Serial Number as string
        /// </summary>
        /// <param name="strDriveLetter">Single letter (e.g., "C")</param>
        /// <returns>string representation of Volume Serial Number</returns>
        public static string GetVolumeSerial(string strDriveLetter)
        {
            uint serNum = 0;
            uint maxCompLen = 0;
            StringBuilder VolLabel = new StringBuilder(256);	// Label
            UInt32 VolFlags = new UInt32();
            StringBuilder FSName = new StringBuilder(256);	// File System Name
            strDriveLetter += ":\\";
            long Ret = GetVolumeInformation(strDriveLetter, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);

            return Convert.ToString(serNum);
        }

        /// <summary>Keeps last drive not to need to check everytime.</summary>
        private static string LastDrive;

        /// <summary>Returns true if the software is registered to any of the codes.</summary>
        /// <param name="Codes">Codes to check</param>
        public static bool IsRegistered(List<long> Codes, string VolName)
        {
            //tries last succesful
            string ss = GetVolumeSerial(LastDrive);
            long nn;
            long.TryParse(ss, out nn);
            if (Codes.IndexOf(nn) >= 0) return true;

            
            //tries all
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo d in drives)
            {
                string s = GetVolumeSerial(d.Name.Substring(0, 1));
                long n;
                long.TryParse(s, out n);
                if (Codes.IndexOf(n)>=0 && VolName.ToLower()==d.VolumeLabel.ToLower())
                {
                    LastDrive=d.Name.Substring(0,1);
                    return true;
                }
            }

            return false;
        }
    }
}
