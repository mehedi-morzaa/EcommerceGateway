namespace EcommerceGateway.CORS
{
    public static class CorsConfig
    {
        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            // Read CORS settings from the configuration
            var Allowpolicies = configuration.GetSection("MorzaaCors").Value;
            string[] policies = [];
            if (Allowpolicies != null)
            {
                policies = Allowpolicies.Split(";");
            }
            services.AddCors(options =>
            {

                options.AddPolicy("MorzaaCorsPolicy", a =>
                {
                    a.WithOrigins(policies)
                     .AllowAnyMethod()
                     .AllowAnyHeader();
                });

            });
        }
    }
}
