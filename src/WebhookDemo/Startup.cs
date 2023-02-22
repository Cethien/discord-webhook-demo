using Blazored.LocalStorage;
using Discord.Webhook;
using WebhookDemo.Services;
using WebhookDemo.Utils;

public static class Startup
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddBlazoredLocalStorage();
        services.AddSingleton(services =>
        {
            var webhookUrl = new DiscordWebhookUrlBuilder()
            {
                Id = Environment.GetEnvironmentVariable("DISCORD_WEBHOOK_ID")!,
                Token = Environment.GetEnvironmentVariable("DISCORD_WEBHOOK_TOKEN")!
            }.Build();

            var webhookClient = new DiscordWebhookClient(webhookUrl);

            return new DiscordService(webhookClient);
        });
    }
}