using Microsoft.VisualStudio.Text.Classification;
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Utilities;

namespace Ony.SyntaxLume;

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - public")]
[Name("Public Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class PublicModifierFormat : ClassificationFormatDefinition
{
    public PublicModifierFormat()
    {
        DisplayName = "C# Access Modifier - Public";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - private")]
[Name("Private Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class PrivateModifierFormat : ClassificationFormatDefinition
{
    public PrivateModifierFormat()
    {
        DisplayName = "C# Access Modifier - Private";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - internal")]
[Name("Internal Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class InternalModifierFormat : ClassificationFormatDefinition
{
    public InternalModifierFormat()
    {
        DisplayName = "C# Access Modifier - Internal";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "access modifier - protected")]
[Name("Protected Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class ProtectedModifierFormat : ClassificationFormatDefinition
{
    public ProtectedModifierFormat()
    {
        DisplayName = "C# Access Modifier - Protected";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - virtual")]
[Name("Virtual Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class VirtualModifierFormat : ClassificationFormatDefinition
{
    public VirtualModifierFormat()
    {
        DisplayName = "C# Modifier - Virtual";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - abstract")]
[Name("Abstract Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class AbstractModifierFormat : ClassificationFormatDefinition
{
    public AbstractModifierFormat()
    {
        DisplayName = "C# Modifier - Abstract";
        ForegroundColor = Colors.Gray;
    }
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - sealed")]
[Name("Sealed Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class SealedModifierFormat : ClassificationFormatDefinition
{
	public SealedModifierFormat()
	{
		DisplayName = "C# Modifier - Sealed";
		ForegroundColor = Colors.DarkGray;
	}
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - override")]
[Name("Override Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class OverrideModifierFormat : ClassificationFormatDefinition
{
	public OverrideModifierFormat()
	{
		DisplayName = "C# Modifier - Override";
		ForegroundColor = Colors.Gray;
	}
}

[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "modifier - static")]
[Name("Static Modifier Format")]
[UserVisible(true)]
[Priority(9999)]
[Order(After = Priority.High)]
internal sealed class StaticModifierFormat : ClassificationFormatDefinition
{
	public StaticModifierFormat()
	{
		DisplayName = "C# Modifier - Static";
		ForegroundColor = Colors.Gray;
	}
}