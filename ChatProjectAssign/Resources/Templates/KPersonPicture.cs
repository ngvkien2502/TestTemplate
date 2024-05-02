

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ChatProjectAssign.Resources.Templates;
public class KPersonPicture : Control
{
    public string NoteText
    {
        get => (string)GetValue(NoteTextProperty);
        set => SetValue(NoteTextProperty, value);
    }
    public static readonly DependencyProperty NoteTextProperty =
        DependencyProperty.Register(nameof(NoteText), typeof(string), typeof(KPersonPicture), new PropertyMetadata(null));
}
