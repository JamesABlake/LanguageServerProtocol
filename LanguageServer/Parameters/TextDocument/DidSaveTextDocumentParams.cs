namespace LanguageServer.Parameters.TextDocument {
	public class DidSaveTextDocumentParams {
		public TextDocumentIdentifier textDocument { get; set; }

		public string text { get; set; }
	}
}
