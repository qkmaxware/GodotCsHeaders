using Godot;
using System;

namespace Qkmaxware.GodotAddons.Inspector {

[Tool]
public class InspectorHeaderPlugin : EditorPlugin {
	
	private EditorInspectorPlugin headerPlugin = new InspectorHeaderEditorInspectorPlugin();

	public override void _EnterTree() {
		base._EnterTree();
		this.AddInspectorPlugin(headerPlugin);
	}

	public override void _ExitTree() {
		base._ExitTree();
		this.RemoveInspectorPlugin(headerPlugin);
	}
}

}
