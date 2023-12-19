using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.Constant
{
    public class Mapper<T>
    {
        public static T Map (T source, T destina)
        {
            var type = typeof(T);
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                if (property.Name.ToLower() == "id")
                {
                    continue;
                }

                var updatedValue = property.GetValue(destina);
                if (updatedValue != null && !IsDefaultValue(updatedValue))
                {
                    var currentValue = property.GetValue(source)!;
                    if (!AreEqual(currentValue, updatedValue))
                    {
                        property.SetValue(source, updatedValue);
                    }
                }
            }

            return source;
        }

        private static bool AreEqual(object source, object destina)
        {
            return object.Equals(source, destina);
        }

        private static bool IsDefaultValue(object value)
        {
            return value switch
            {
                0 => true, 
                0L => true,  
                0.0 => true,  
                0.0F => true,  
                0.0M => true,  
                null => true,  
                _ => false
            };
        }
    }
}
