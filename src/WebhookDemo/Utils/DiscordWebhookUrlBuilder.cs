namespace WebhookDemo.Utils;

public class DiscordWebhookUrlBuilder
{
    public string Id { get; set; } = default!;
    public string Token { get; set; } = default!;

    public string Build()
    {
        return $"https://discord.com/api/webhooks/{Id}/{Token}";
    }
}