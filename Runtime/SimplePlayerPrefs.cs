namespace Produktivkeller.SimplePlayerPrefs
{
    public static class SimplePlayerPrefs
    {
        private static ISimplePlayerPrefsStrategy _simplePlayerPrefsStrategy;

        public static void SetPlayerPrefsStrategy(ISimplePlayerPrefsStrategy simplePlayerPrefsStrategy)
        {
            _simplePlayerPrefsStrategy = simplePlayerPrefsStrategy;
        }

        private static void InitializeStrategyIfNecessary()
        {
            if (_simplePlayerPrefsStrategy != null)
            {
                return;
            }

            _simplePlayerPrefsStrategy = new SimplePlayerPrefsDefaultStrategy();
        }

        public static void DeleteAll()
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.DeleteAll();
        }

        public static void DeleteKey(string key)
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.DeleteKey(key);
        }

        public static float GetFloat(string key)
        {
            InitializeStrategyIfNecessary();

            return _simplePlayerPrefsStrategy.GetFloat(key);
        }

        public static int GetInt(string key)
        {
            InitializeStrategyIfNecessary();

            return _simplePlayerPrefsStrategy.GetInt(key);
        }

        public static string GetString(string key)
        {
            InitializeStrategyIfNecessary();

            return _simplePlayerPrefsStrategy.GetString(key);
        }

        public static bool HasKey(string key)
        {
            InitializeStrategyIfNecessary();

            return _simplePlayerPrefsStrategy.HasKey(key);
        }

        public static void Save()
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.Save();
        }

        public static void SetFloat(string key, float value)
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.SetFloat(key, value);
        }

        public static void SetInt(string key, int value)
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.SetInt(key, value);
        }

        public static void SetString(string key, string value)
        {
            InitializeStrategyIfNecessary();

            _simplePlayerPrefsStrategy.SetString(key, value);
        }
        
        public static void Load()
        {
            _simplePlayerPrefsStrategy.Load();
        }
        
        public static bool StrategyIsSet()
        {
            return _simplePlayerPrefsStrategy != null;
        }
        
        public static bool IsReady()
        {
            if (!StrategyIsSet())
            {
                return false;
            }
            
            return _simplePlayerPrefsStrategy.IsReady();
        }
    }
}
