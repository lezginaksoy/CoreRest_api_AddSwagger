# CoreRest_API

# What is Swagger? 
 
Swagger is a simple yet powerful representation of your RESTful API.
With the largest ecosystem of API tooling on the planet, thousands of developers are supporting Swagger 
in almost every modern programming language and deployment environment.
 
# Step 1 Adding Swagger to Web API Project 
To add Swagger to Web API, we just need to install an open source project called Swashbuckle via NuGet.

# Step 2 Install Swagger from NuGet

# Step 4 Configuring Swagger
At minimum, we need this line to enable Swagger and Swagger UI. 

        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddSingleton<IData, DummyData>();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Core RESTful API", Description = "using swagger for core rest api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseSwagger();
           
            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", " Core RESTful API v1");
            });
        }
