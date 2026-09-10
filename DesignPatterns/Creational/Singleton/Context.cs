namespace DesignPatterns.Creational.Singleton
{
    internal class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Initializing Context");
            _settings["1"] = "a";
            _settings["2"] = "b";
            _settings["3"] = "c";
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        private static Context? _instance;
        //podstawowa implemenacja singletona nie jest thread safe
        /*public static Context GetInstance()
        {
            if(_instance is null)
                _instance = new Context();
            return _instance;
        }*/

        private static readonly Lock _instanceLock = new();

        //implementacja singletona thread safe
        /*public static Context GetInstance()
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                    _instance = new Context();
            }
            return _instance;
        }*/

        //implementacja singletona thread safe z podwójnym sprawdzeniem
        /*public static Context GetInstance()
        {
            if (_instance is null)
            {
                lock (_instanceLock)
                {
                    if (_instance is null)
                        _instance = new Context();
                }
            }
            return _instance;
        }*/

        //jawny statyczny konstruktor usuwa flagę "beforefieldinit"
        //dzięku temu mamy gwarancję, że instancja zostanie utworzona w momencie pierwszego odwołania do klasy
        static Context()
        {
        }
        //implementacja singletona thread safe z wykorzystaniem statycznego konstruktora
        public static Context Instance { get; } = new Context();


        //implementacja singletona thread safe z wykorzystaniem Lazy<T>
        /*private static readonly Lazy<Context> _lazyInstance = new Lazy<Context>(() => new Context());
        public static Context GetLazyInstance()
        {
            return _lazyInstance.Value;
        }*/
    }
}
