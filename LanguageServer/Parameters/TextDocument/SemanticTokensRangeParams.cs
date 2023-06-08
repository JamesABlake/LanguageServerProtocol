namespace LanguageServer.Parameters.TextDocument;
/// <summary>
/// For <c>textDocument/semanticTokens/range</c>.
/// </summary>
/// <seealso>Spec 3.16.0</seealso>
public class SemanticTokensRangeParams {
	/// <summary>
	///  The text document.
	/// </summary>
	public required TextDocumentIdentifier textDocument { get; set; }

	/// <summary>
	///  The range the semantic tokens are requested for.
	/// </summary>
	public required Range range { get; set; }
}
