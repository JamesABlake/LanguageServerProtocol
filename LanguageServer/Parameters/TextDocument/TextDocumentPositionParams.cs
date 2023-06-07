namespace LanguageServer.Parameters.TextDocument {
	public class TextDocumentPositionParams {
		public TextDocumentIdentifier textDocument { get; set; }

		public Position position { get; set; }
	}
}
