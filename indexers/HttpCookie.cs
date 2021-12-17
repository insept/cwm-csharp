namespace Indexers // Note: actual namespace depends on the project name.
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictiornary;

        public HttpCookie()
        {
            _dictiornary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictiornary[key];
            }
            set 
            {
                _dictiornary[key] = value;
            }
        }
    }
}
