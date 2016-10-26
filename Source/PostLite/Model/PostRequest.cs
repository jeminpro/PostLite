using System.Collections.Generic;

namespace PostLite.Model
{
    public class PostRequest
    {
        public PostRequest()
        {
            Header = new List<HeaderKeyValue>();
        }

        public string URL { get; set; }

        public string Body { get; set; }
        
        public List<HeaderKeyValue> Header { get; set; }
    }
}
