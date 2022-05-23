using Godot;
using System;
using System.Reflection;

namespace Qkmaxware.GodotAddons.Inspector {

[Tool]
public class InspectorHeaderEditorInspectorPlugin : EditorInspectorPlugin {
    public override bool CanHandle(Godot.Object obj) {
        return obj is Node;
    }

    public override bool ParseProperty(Godot.Object obj, int typeId, string path, int hint, string hintText, int usage) {
        if (obj.GetScript() is CSharpScript script) {
            var demo_instance = script.New();
            var type = demo_instance.GetType();

            var name = path;
            var header = (type.GetField(name)?.GetCustomAttribute<HeaderAttribute>()) ?? (type.GetProperty(name)?.GetCustomAttribute<HeaderAttribute>());

            if (header != null) {
                var label = new Godot.Label();
                label.Text = header.Name;

                // TODO bold labels
                /*var label = new Godot.RichTextLabel();
                label.Text = header.Name;
                label.BbcodeEnabled = true;
                label.AppendBbcode($"[b]{header.Name}[/b]");*/
                this.AddCustomControl(label);
            }
        }

        return false;
    }
}

}