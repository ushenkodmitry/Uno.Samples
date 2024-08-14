using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace UnoChat.Models;

public class MessageTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) =>
           SelectTemplateCore(item);

    protected override DataTemplate SelectTemplateCore(object item)
    {
        return item switch
        {
            Model model when model.Sender.IsMe => FromTemplate,
            _ => ToTemplate
        };
    }

    public DataTemplate FromTemplate { get; set; }

    public DataTemplate ToTemplate { get; set; }
}
