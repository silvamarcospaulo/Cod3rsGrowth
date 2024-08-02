using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Cod3rsGrowth.Web
{
    public static class ProblemDetailsConfig
    {
        public static void UseProblemDetailsExceptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseExceptionHandler(construtor =>
            {
                construtor.Run(async contexto =>
                {
                    var exceptionHandlerFeature = contexto.Features.Get<IExceptionHandlerFeature>();

                    if (exceptionHandlerFeature != null)
                    {
                        var exception = exceptionHandlerFeature.Error;
                        var problemDetails = CreateProblemDetails(contexto, exception);
                        var logger = loggerFactory.CreateLogger("GlobalExceptionHandler");

                        LogException(logger, exception);

                        contexto.Response.ContentType = "application/problem+json";
                        contexto.Response.StatusCode = problemDetails.Status.GetValueOrDefault(StatusCodes.Status500InternalServerError);

                        var json = JsonConvert.SerializeObject(problemDetails, new JsonSerializerSettings());
                        await contexto.Response.WriteAsync(json);
                    }
                });
            });
        }

        private static ProblemDetails CreateProblemDetails(HttpContext contexto, Exception exception)
        {
            var problemDetails = new ProblemDetails
            {
                Instance = contexto.Request.Path,
                Title = "Erro. " + exception.Message,
                Status = StatusCodes.Status500InternalServerError,
                Type = "https://tools.ietf.org/html/rfc7807",
                Detail = exception.StackTrace
            };

            switch (exception)
            {
                case BadHttpRequestException badRequest:
                    ConfigureBadRequestProblemDetails(problemDetails, badRequest);
                    break;
                case ValidationException validationException:
                    ConfigureValidationProblemDetails(problemDetails, validationException);
                    break;
                case SqlException sqlException:
                    ConfigureSqlProblemDetails(problemDetails, sqlException);
                    break;
                case NullReferenceException nullReferenceException:
                    ConfigureNullReferenceExceptionProblemDetails(problemDetails, nullReferenceException);
                    break;
                default:
                    ConfigureDefaultProblemDetails(problemDetails, exception);
                    break;
            }

            return problemDetails;
        }

        private static void ConfigureBadRequestProblemDetails(ProblemDetails problemDetails, BadHttpRequestException exception)
        {
            problemDetails.Title = "Requisição inválida. " + exception.Message;
            problemDetails.Status = StatusCodes.Status400BadRequest;
            problemDetails.Type = "https://tools.ietf.org/html/rfc7807#section-6.5.1";
            problemDetails.Detail = exception.StackTrace;
        }

        private static void ConfigureValidationProblemDetails(ProblemDetails problemDetails, ValidationException exception)
        {
            problemDetails.Title = "Erro de validação. " + exception.Message;
            problemDetails.Status = StatusCodes.Status400BadRequest;
            problemDetails.Type = "https://tools.ietf.org/html/rfc7807#section-6.5.1";
            problemDetails.Detail = exception.StackTrace;
        }

        private static void ConfigureSqlProblemDetails(ProblemDetails problemDetails, SqlException exception)
        {
            problemDetails.Title = "Erro ao acessar o banco de dados. " + exception.Message;
            problemDetails.Status = StatusCodes.Status500InternalServerError;
            problemDetails.Type = "https://tools.ietf.org/html/rfc7807#section-6.6.1";
            problemDetails.Detail = exception.StackTrace;
        }

        private static void ConfigureDefaultProblemDetails(ProblemDetails problemDetails, Exception exception)
        {
            problemDetails.Title = "Erro. " + exception.Message;
            problemDetails.Status = StatusCodes.Status500InternalServerError;
            problemDetails.Type = "https://tools.ietf.org/html/rfc7807#section-6.6.1";
            problemDetails.Detail = exception.StackTrace;
        }

        private static void ConfigureNullReferenceExceptionProblemDetails(ProblemDetails problemDetails, Exception exception)
        {
            problemDetails.Title = "Erro. Registro não encontrado. " + exception.Message;
            problemDetails.Status = StatusCodes.Status500InternalServerError;
            problemDetails.Type = "https://tools.ietf.org/html/rfc7807#section-6.6.1";
            problemDetails.Detail = exception.StackTrace;
        }
        
        private static void LogException(ILogger logger, Exception exception)
        {
            logger.LogError($"Erro: {exception}");
        }
    }
}