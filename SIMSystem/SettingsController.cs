using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIMSystem
{
    public class SettingsController
    {

        public SettingsController()
        {

        }

        public bool UpdateSettings(string server, string database, string username, string password)
        {
            string appSettingsJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            try
            {
                if (appSettingsJsonFilePath == null)
                {
                    appSettingsJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                }

                var json = File.ReadAllText(appSettingsJsonFilePath);

                var jsonSetting = new JsonSerializerSettings();
                jsonSetting.Converters.Add(new ExpandoObjectConverter());
                jsonSetting.Converters.Add(new StringEnumConverter());
                dynamic jsonObj = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSetting);

                jsonObj.Settings.SERVER = server;
                jsonObj.Settings.DATABASE = database;
                jsonObj.Settings.USERNAME = username;
                jsonObj.Settings.PASSWORD = password;

                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented, jsonSetting);

                File.WriteAllText(appSettingsJsonFilePath, output);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class Config
    {
        public string server { get; set; }
        public string database { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
