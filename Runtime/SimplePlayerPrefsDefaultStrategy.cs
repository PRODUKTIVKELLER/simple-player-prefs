using UnityEngine;

namespace Produktivkeller.SimplePlayerPrefs
{
    public class SimplePlayerPrefsDefaultStrategy : ISimplePlayerPrefsStrategy
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Init()
        {
            if (Application.isConsolePlatform)
            {
                return;
            }

            Debug.Log("Using 'Default' version of 'SimplePlayerPrefs' implementation.");
            SimplePlayerPrefs.SetPlayerPrefsStrategy(new SimplePlayerPrefsDefaultStrategy());
        }

        public void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }

        public void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }

        public float GetFloat(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }

        public int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        public void Save()
        {
            PlayerPrefs.Save();
        }

        public void SetFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }

        public void Load()
        {
        }

        public bool IsReady()
        {
            return true;
        }
    }
}