using System;
using Godot;
using System.Reflection;

namespace Qkmaxware.GodotAddons.Inspector {

[System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Property)]
public class HeaderAttribute : System.Attribute {
    public string Name {get; set;}
    public HeaderAttribute(string name) {
        this.Name = name;
    }
}

}
