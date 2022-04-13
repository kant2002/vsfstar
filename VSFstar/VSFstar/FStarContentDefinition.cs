using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace VSFstar
{
    public class FStarContentDefinition
    {
        [Export]
        [Name("fst")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition FstContentTypeDefinition;

        [Export]
        [FileExtension(".fst")]
        [ContentType("fst")]
        internal static FileExtensionToContentTypeDefinition FstFileExtensionDefinition;

        [Export]
        [FileExtension(".fsti")]
        [ContentType("fst")]
        internal static FileExtensionToContentTypeDefinition FstiFileExtensionDefinition;

    }
}
