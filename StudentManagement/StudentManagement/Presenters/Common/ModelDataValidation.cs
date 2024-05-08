using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Presenters.Common;

public class ModelDataValidation
{
    public void Validate(object model)
    {
        var errorMessage = string.Empty;
        var results = new List<ValidationResult>();
        var context = new ValidationContext(model);
        var isValid = Validator.TryValidateObject(model, context, results, true);

        if (isValid == false)
        {
            foreach (var item in results)
            {
                errorMessage += item.ErrorMessage + "\n";
            }

            throw new Exception(errorMessage);
        }
    }
}
