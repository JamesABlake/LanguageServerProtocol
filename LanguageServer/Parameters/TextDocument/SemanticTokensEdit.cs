namespace LanguageServer.Parameters.TextDocument;

/// <summary>
/// For <c>textDocument/semanticTokens/full/delta</c>.
/// </summary>
/// <seealso>Spec 3.16.0</seealso>
/// <seealso cref="LanguageServer.Parameters.TextDocument.SemanticTokensDelta"/>
public class SemanticTokensEdit {
	/// <summary>
	/// The start offset of the edit.
	/// </summary>
	public uint start { get; set; }

	/// <summary>
	/// The count of elements to remove.
	/// </summary>
	public uint deleteCount { get; set; }

	/// <summary>
	/// The elements to insert.
	/// </summary>
	public uint[] data { get; set; }
}
