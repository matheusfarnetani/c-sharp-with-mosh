﻿namespace Indexers
{
    public class HttpCookie
    {
        readonly private Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}