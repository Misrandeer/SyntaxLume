using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

#pragma warning disable CS0649

namespace Ony.SyntaxLume;

internal static class ClassificationTypes
{
	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - public")]
	internal static ClassificationTypeDefinition PublicModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - private")]
	internal static ClassificationTypeDefinition PrivateModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - internal")]
	internal static ClassificationTypeDefinition InternalModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("access modifier - protected")]
	internal static ClassificationTypeDefinition ProtectedModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - virtual")]
	internal static ClassificationTypeDefinition VirtualModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - abstract")]
	internal static ClassificationTypeDefinition AbstractModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - sealed")]
	internal static ClassificationTypeDefinition SealedModifierType = null;
	
	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - override")]
	internal static ClassificationTypeDefinition OverrideModifierType = null;

	[Export(typeof(ClassificationTypeDefinition))]
	[Name("modifier - static")]
	internal static ClassificationTypeDefinition StaticModifierType = null;
	
}