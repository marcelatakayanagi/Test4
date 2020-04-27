using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Extras
{
    public static class Serializer
    {

        public static bool IsSerializable(object obj)
        {
            Type type = obj.GetType(); //altera esta linha para obter o tipo do objeto
            foreach(var att in type.GetCustomAttributes(true))
            {
                if (att is ISerializable) return true;
            }
            return false;
        }
    }
}
