namespace LanguageServer.Parameters.TextDocument {
	public class DocumentOnTypeFormattingParams {
		public TextDocumentIdentifier textDocument { get; set; }

		public Position position { get; set; }

		public string ch { get; set; }

		public FormattingOptions options { get; set; }
	}
}
