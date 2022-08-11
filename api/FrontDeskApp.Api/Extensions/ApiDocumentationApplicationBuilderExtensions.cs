﻿namespace Microsoft.AspNetCore.Builder
{
    public static class ApiDocumentationApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseApiDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Front Desk App API");
                c.RoutePrefix = "docs";
            });

            return app;
        }
    }
}
