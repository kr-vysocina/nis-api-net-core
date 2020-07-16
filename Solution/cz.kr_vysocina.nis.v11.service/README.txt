Návod k použití      

Přidat závislost na nuget balíčku cz.kr_vysocina.nis.v11.api

Ve třídě Startup.cs je nutné mít následující implementaci
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDataProvider, MockDataProvider>(); //Registrace implementace pro získání dat pod interface IDataProvider

            var assembly = typeof(NisApiV11Controller).Assembly; //Získání assembly NIS API Controlleru

            services.AddControllers()
                .AddApplicationPart(assembly); //Přidání NIS API Controlleru

            services.AddMvc()
                .AddXmlSerializerFormatters() //Přidání XML serializeru
                .AddApplicationPart(assembly); //Přidání assembly do MVC
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseRouting(); //Použít routování pomocí Route atributu který NIS API Controller používá            
            app.UseEndpoints(routes => { routes.MapControllers(); }); //Povolit mapování route na controllery
        }
        
Případně je možné definovat vlastní controller a použít dědičnost

    public class NISApiV11CustomController : NisApiV11Controller
    {
        public NISApiV11CustomController(
            IDataProvider dataProvider,
            ILogger<NisApiV11Controller> logger
        ) : base(dataProvider, logger)
        {
        }
    }
    
Lze přidat závislost na nuget balíčku cz.kr_vysocina.nis.v11.mock a registrovat implementaci MockDataProvider pro vyzkoušení, zda služba běží a vrací mockovaná data

Případně je možné použít pouze balíček cz.kr_vysocina.nis.v11.core, který obsahuje datové modely, a implementovat vlastní rozhraní