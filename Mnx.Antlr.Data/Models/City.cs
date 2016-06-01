using Newtonsoft.Json;

namespace Mnx.Antlr.Data.Models
{
    public class City
    {
        public string Market { get; set; }
        public string FullName { get; set; }
        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = FullName.Split(',')[0];
                }
                return _name;
            }
        }
        private string _state;
        public string State
        {
            get
            {
                if (string.IsNullOrEmpty(_state))
                {
                    _state = FullName.Split(',')[1];
                }
                return _state;
            }
        }
    }
}
