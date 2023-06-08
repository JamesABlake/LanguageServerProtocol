namespace LanguageServer.Parameters.TextDocument;
/// <summary>
/// For <c>textDocument/semanticTokens/full/delta</c>.
/// </summary>
/// <seealso>Spec 3.16.0</seealso>
public class SemanticTokensDeltaParams {
	/// <summary>
	///  The text document.
	/// </summary>
	public required TextDocumentIdentifier textDocument { get; set; }

	/// <summary>
	///  The result id of a previous response. The result Id can either point to
	///  a full response or a delta response depending on what was received last.
	/// </summary>
	public required string previousResultId { get; set; }
}
