using System.Text.Json;

namespace WebhookDemo.Data;

public class WebhookData
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string Avatar { get; set; } = default!;

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}