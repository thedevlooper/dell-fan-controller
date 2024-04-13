using System.Collections.Generic;
using System.IO;
using System.Web;

namespace DellFanController
{
    /// <summary>
    /// Class for managging configuration files.
    /// </summary>
    internal class Config
    {
        // config file path
        private const string configFile = "dellfancontroller.ini";

        /// <summary>
        /// Structure for configuration parsing.
        /// </summary>
        public class ConfigStruct
        {
            public string Name;
            public string Value;
            public bool IsEmpty;
        }

        // list with configuration parsed from file.
        private static List<ConfigStruct> configList = new List<ConfigStruct>();

        /// <summary>
        /// Setup and load the config into memory.
        /// </summary>
        public static void Setup()
        {
            if (!File.Exists(configFile))
            {
                CreateConfig();
            }

            LoadConfig();
        }

        /// <summary>
        /// Creates a config file.
        /// </summary>
        public static void CreateConfig()
        {
            List<string> list = new List<string>()
            {
                "usernm = ",
                "passwd = ",
                "ipaddr = 0.0.0.0"
            };

            File.WriteAllLines(configFile, list);
        }

        /// <summary>
        /// Loads configuration into list.
        /// </summary>
        public static void LoadConfig()
        {
            // clears the config list, to avoid problem with existing entry.
            if (configList.Count > 0)
            {
                configList.Clear();
            }

            foreach (var configLine in File.ReadLines(configFile))
            {
                if (configLine.Contains("="))
                {
                    string name = configLine.Split('=')[0].Trim();
                    string value = configLine.Split('=')[1].Trim();

                    configList.Add(new ConfigStruct { Name = name, Value = value, IsEmpty = value.Trim().Length == 0 });
                }
            }
        }

        /// <summary>
        /// Change the value of the key and write into file.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void ChangeValueOfKey(string key, string value)
        {
            Setup();

            for (int i = 0; i < configList.Count; i++)
            {
                if (configList[i].Name == key)
                {
                    configList[i].Value = value;
                    configList[i].IsEmpty = value.Trim().Length == 0;
                    break;
                }
            }

            string rawConfig = "";

            foreach (var configLine in configList)
            {
                rawConfig += configLine.Name.Trim() + " = " + configLine.Value.Trim() + "\n";
            }

            File.WriteAllText(configFile, rawConfig);

            Setup();
        }

        /// <summary>
        /// Returns a config value by key name.
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string GetValue(string keyName)
        {
            foreach (var configLine in configList)
            {
                if (configLine.Name == keyName)
                {
                    return configLine.Value;
                }
            }

            return null;
        }
        
        /// <summary>
        /// Checks if is the key empty.
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static bool IsEmpty(string keyName)
        {
            foreach (var configLine in configList)
            {
                if (configLine.Name == keyName && configLine.Value.Trim().Length == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
