using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace VSFstar
{
    public class FStarContentDefinition
    {
        public const string FStarContentType = "fstar";

        [Export]
        [Name(FStarContentType)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition FstContentTypeDefinition;

        [Export]
        [FileExtension(".fst")]
        [ContentType(FStarContentType)]
        internal static FileExtensionToContentTypeDefinition FstFileExtensionDefinition;

        [Export]
        [FileExtension(".fsti")]
        [ContentType(FStarContentType)]
        internal static FileExtensionToContentTypeDefinition FstiFileExtensionDefinition;

    }
}
