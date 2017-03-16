using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Configuration;

namespace RappiChallenge.Persistence.CubePersistence.IO
{
    public class IODAL
    {
        private static string IO_AppSetting = "Io";

        public static void SaveDimensions(int dimensions)
        {
            if (File.Exists(ConfigurationManager.AppSettings[IO_AppSetting]))
            {
                File.Delete(ConfigurationManager.AppSettings[IO_AppSetting]);
            }

            File.WriteAllText(ConfigurationManager.AppSettings[IO_AppSetting], dimensions.ToString());
        }

        public static int GetDimensions()
        {
            if (!File.Exists(ConfigurationManager.AppSettings[IO_AppSetting]))
            {
                return 0;
            }

            return Convert.ToInt32(File.ReadAllText(ConfigurationManager.AppSettings[IO_AppSetting]));
        }

    }
}
