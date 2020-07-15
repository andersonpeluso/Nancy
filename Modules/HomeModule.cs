using Nancy;

namespace NancyAPI.Module
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("/api/teste") // Alias
        {
            Get("/", _ => "Hello World from Nancy!");
        }
    }
}