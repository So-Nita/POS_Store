using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace POSLibrary.Constant;

public class DataValidator<T>
{
    public static List<string> ValidateDynamicTypes(T obj)
    {
        var validationErrors = new List<string>();

        foreach (var property in typeof(T).GetProperties())
        {
            var value = property.GetValue(obj);
            
            // Check for the [Required] attribute to determine if the property is required
            var isRequired = Attribute.IsDefined(property, typeof(RequiredAttribute));

            // Use custom validation methods based on property types and requirements
            if (property.PropertyType == typeof(string))
            {
                ValidateString(property.Name, value?.ToString()!, isRequired, validationErrors);
            }
            else if (property.PropertyType == typeof(double?) || property.PropertyType == typeof(double))
            {
                ValidateNumber(property.Name, value!, isRequired, validationErrors);
            }
        }

        return validationErrors;
    }
    private static void ValidateString(string propertyName, string value, bool isRequired, List<string> errors)
    {
        if (isRequired && string.IsNullOrEmpty(value) || value.Trim()=="")
        {
            errors.Add($"Property {propertyName} is required.");
        }
    }
    private static void ValidateNumber(string propertyName, object value, bool isRequired, List<string> errors)
    {
        if (isRequired && value == null)
        {
            errors.Add($"{propertyName} is required and must be a valid number.");
        }
        else if (value != null && (value is double || value is double?))
        {
            var numericValue = (double?)value;
            if (isRequired && numericValue == null)
            {
                errors.Add($"{propertyName} is required");
            }
            else if (numericValue != null && numericValue <= 0)
            {
                errors.Add($"{propertyName} must be greater than 0.");
            }
        }
    }


    /*private static void ValidateNumber(string propertyName, object value, bool isRequired, List<string> errors)
    {
        if (isRequired && value == null)
        {
            errors.Add($"Property {propertyName} is required and must be a valid number.");
        }
    }*/
}
