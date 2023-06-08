namespace LanguageServer.Parameters.TextDocument;
/// <summary>
/// For <c>textDocument/semanticTokens/full/delta</c>.
/// </summary>
/// <seealso>Spec 3.16.0</seealso>
public class SemanticTokensDelta {
	public string? resultId { get; init; }

	/// <summary>
	/// The semantic token edits to transform a previous result into a new result.
	/// </summary>
	public required SemanticTokensEdit[] edits { get; set; }
}
