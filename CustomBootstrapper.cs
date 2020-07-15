using Nancy;
using Nancy.Configuration;

public class CustomBootstrapper : DefaultNancyBootstrapper
{
    public override void Configure(INancyEnvironment environment)
    {
        environment.Tracing(enabled: false, displayErrorTraces: true);
    }
}