namespace LanguageServer.Parameters.TextDocument {

	/// <summary>
	/// For <c>textDocument/semanticTokens/full</c>
	/// </summary>
	/// <seealso>Spec 3.16.0</seealso>
	public class SemanticTokens {

		/// <summary>
		/// An optional result id. If provided and clients support delta updating the 
		/// client will include the result id in the next semantic token request. 
		/// A server can then instead of computing all semantic tokens again simply 
		/// send a delta.
		/// </summary>
		/// <remarks>
		/// Not Implemented
		/// </remarks>
		/// <seealso>Spec 3.16.0</seealso>
		public string resultId { get; set; }

		/// <summary>
		/// The actual tokens.
		/// </summary>
		public uint[] data { get; set; }
	}
}
