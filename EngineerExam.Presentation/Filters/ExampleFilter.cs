using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Dapper;
using Microsoft.Data.SqlClient;
namespace EngineerExam.WebApi.Filters;

public class ExampleFilter : IAsyncActionFilter
{
    private readonly IConfiguration _configuration;
    public ExampleFilter(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (context.HttpContext.User.Identity.IsAuthenticated)
        {
            var url = context.HttpContext.Request.Path.Value.ToLower();
            url = url.Replace("/api", "");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServercnn")))
            {
                await connection.OpenAsync();
                await connection.CloseAsync();   
                //var userId = context.HttpContext.User.GetUserCliam("UserId");

                //string query = @"
                //              IF EXISTS (
                //                SELECT 1
                //                FROM Permissions permissions
                //                WHERE permissions.Route = @Route
                //            )
                //                SELECT 'true' as Result
                //            ELSE
                //                SELECT 'false' as Result
                //                    ";

                //var isExistRouteResult = await connection.QueryAsync<bool>(
                //    query,
                //    new { Route = url }
                //);
            }
                await next();
        }
        else
        {
            context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
        }
    }
}