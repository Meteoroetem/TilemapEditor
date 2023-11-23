using Adw;

namespace TilemapEditor;

public class TilemapEditorWindow : Window{
	[Gtk.Connect] private readonly HeaderBar headerBar;
    [Gtk.Connect] private readonly SplitButton openButton;
    [Gtk.Connect] private readonly Gtk.Button newButton;

    private TilemapEditorWindow(Gtk.Builder builder, string name) : base(builder.GetPointer(name), false){
        builder.Connect(this);
    }

    public TilemapEditorWindow() : this(new Gtk.Builder("tilemapeditor.ui"), "window")
    {}
}