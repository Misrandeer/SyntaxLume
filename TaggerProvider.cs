using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Tagging;

namespace Ony.SyntaxLume;

[Export(typeof(ITaggerProvider))]
[ContentType("CSharp")]
[TagType(typeof(ClassificationTag))]
internal class TaggerProvider : ITaggerProvider
{
	[Import] internal IClassificationTypeRegistryService ClassificationTypeRegistry { get; set; }
	[Import] internal IClassifierAggregatorService ClassifierAggregator { get; set; }

	private bool _isCreatingTagger = false;
    
	public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
	{
		if (buffer == null)
			return null;

		if (_isCreatingTagger)
			return null;
		
		if (!buffer.ContentType.IsOfType("CSharp"))
			return null;
		
		try
		{
			_isCreatingTagger = true;

			var classifier = ClassifierAggregator.GetClassifier(buffer);

			return new Tagger(buffer, ClassificationTypeRegistry, classifier) as ITagger<T>;
		}
		finally
		{
			_isCreatingTagger = false;
		}
	}
	

}
