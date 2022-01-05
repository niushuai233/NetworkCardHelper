using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCardHelper.Base
{
    public class MapExt : Dictionary<string, object>
    {
        public bool IsNullOrEmpty()
        {
            return this.Count == 0;
        }

        public bool IsNotNullOrEmpty()
        {
            return !IsNullOrEmpty();
        }

        public void Put(string key, object value)
        {
            this.Add(key, value);
        }

        public object Get(string key)
        {
            try
            {
                return this[key];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
