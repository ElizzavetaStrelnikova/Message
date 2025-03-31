using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageClient.Pages;

public class MessageListModel : PageModel
{
    private readonly ILogger<MessageListModel> _logger;

    public MessageListModel(ILogger<MessageListModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

