using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedOrBlack
{
    public class Preferences
    {
        /// <summary>
        /// Gets or sets a value of a key. If the key doesn't exist, it creates with default color
        /// </summary>
        /// <param name="key">Key in ApplicationSettings</param>
        /// <param name="defaultColor">Default color to use when the key doesn't in ApplicationSettings</param>
    /*    /// <returns>Color in ApplicatonSetting or default color if the key doesn't exist</returns>
        public Color CreateIfNotExists(string key, Color defaultColor)
        {
            Color rtn = defaultColor;

            if (!IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                IsolatedStorageSettings.ApplicationSettings[key] = defaultColor;
            }
            else
            {
                rtn = (Color)IsolatedStorageSettings.ApplicationSettings[key];
            }

            return rtn;
        }

        /// <summary>
        /// Gets or sets a value of a key. If the key doesn't exist, it creates with default value
        /// </summary>
        /// <param name="key">Key in ApplicationSettings</param>
        /// <param name="defaultColor">Default value to use when the key doesn't in ApplicationSettings</param>
        /// <returns>Color in ApplicatonSetting or default value if the key doesn't exist</returns>
        public decimal CreateIfNotExists(string key, decimal defaultvalue)
        {
            decimal rtn = defaultvalue;

            if (!IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                IsolatedStorageSettings.ApplicationSettings[key] = defaultvalue;
            }
            else
            {
                rtn = (decimal)IsolatedStorageSettings.ApplicationSettings[key];
            }

            return rtn;
        }

        /// <summary>
        /// Gets or sets a value of a key. If the key doesn't exist, it creates with default value
        /// </summary>
        /// <param name="key">Key in ApplicationSettings</param>
        /// <param name="defaultColor">Default value to use when the key doesn't in ApplicationSettings</param>
        /// <returns>Color in ApplicatonSetting or default value if the key doesn't exist</returns>
        public int CreateIfNotExists(string key, int defaultvalue)
        {
            int rtn = defaultvalue;

            if (!IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                IsolatedStorageSettings.ApplicationSettings[key] = defaultvalue;
            }
            else
            {
                string s = IsolatedStorageSettings.ApplicationSettings[key].ToString();
                if (!string.IsNullOrEmpty(s))
                {
                    rtn = Convert.ToInt32(s);
                }
                else
                {
                    rtn = defaultvalue;
                }
            }

            return rtn;
        }

        /// <summary>
        /// Gets or sets a value of a key. If the key doesn't exist, it creates with default value
        /// </summary>
        /// <param name="key">Key in ApplicationSettings</param>
        /// <param name="defaultColor">Default value to use when the key doesn't in ApplicationSettings</param>
        /// <returns>Color in ApplicatonSetting or default value if the key doesn't exist</returns>
        public string CreateIfNotExists(string key, string defaultValue)
        {
            string rtn = defaultValue;

            if (!IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                IsolatedStorageSettings.ApplicationSettings[key] = defaultValue;
                IsolatedStorageSettings.ApplicationSettings.Save();
            }
            else
            {
                rtn = IsolatedStorageSettings.ApplicationSettings[key].ToString();
            }

            return rtn;
        }

        /// <summary>
        /// Detect if the key exists in the ApplicationSettings
        /// </summary>
        /// <param name="key">Key to find in ApplicationSettings</param>
        /// <returns>True if the key exists in the ApplicationSettings or False if doesn't exist</returns>
        public bool ExistsKey(string key)
        {
            bool rtn = false;

            if (IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                rtn = true;
            }

            return rtn;
        }

        /// <summary>
        /// Save in ApplicationSettings a new Color value in key
        /// </summary>
        /// <param name="key">Color to save</param>
        /// <param name="value">Name of parameters</param>
        public void SaveSettings(string key, Color value)
        {
            IsolatedStorageSettings.ApplicationSettings[key] = value;
            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        /// <summary>
        /// Save in ApplicationSettings a new string value in key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SaveSettings(string key, string value)
        {
            IsolatedStorageSettings.ApplicationSettings[key] = value;
            IsolatedStorageSettings.ApplicationSettings.Save();
        }
     * */
    }
}
