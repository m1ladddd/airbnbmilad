using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using static AirBnbApi.Model.Location;

namespace AirBnbApi
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    new OpenApiInfo()
                    {
                        Title = "AirBnbApi",
                        Description = "AirBnb api for c# advanced",
                        Version = description.ApiVersion.ToString(),
                    });
                options.CustomSchemaIds(type => type.FullName);
            }
        }
    }
}
