using Discord;
using Discord.Webhook;

namespace WebhookDemo.Services;

public sealed class DiscordService
{
    private DiscordWebhookClient _client;

    public DiscordService(DiscordWebhookClient client)
    {
        _client = client;
    }

    public async Task SendWebhookAsync(Embed embed, string avatarUrl, string username = "some webhook")
    {
        await _client.SendMessageAsync(embeds: new[] { embed }, avatarUrl: avatarUrl, username: username);
    }
}