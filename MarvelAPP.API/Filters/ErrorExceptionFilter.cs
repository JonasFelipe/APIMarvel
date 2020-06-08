using Marvel.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MarvelAPP.API.Filters
{
    public class ErrorExceptionFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context, Func<Task> next)
        {
            try
            {
                await next();
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode code;

            switch (exception)
            {
                case SqlException _:
                    code = HttpStatusCode.InternalServerError;
                    break;
                case ConflictRequestException _:
                    code = HttpStatusCode.Conflict;
                    break;
                default:
                    code = HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonConvert.SerializeObject(new { error = exception.Message, inner = exception.InnerException });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
