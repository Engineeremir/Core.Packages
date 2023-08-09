using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class ValidationProblemDetails : ProblemDetails
{
    public IEnumerable<ValidationExceptionModel> Errors{ get; init; }
    public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
    {
        Errors = errors;
        Title = "Validation error(s)";
        Detail = "One or more validation errors occured";
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/probs/validation";
    }
}

