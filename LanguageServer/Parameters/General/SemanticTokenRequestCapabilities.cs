namespace LanguageServer.Parameters.General {
	/// <summary>
	/// For <c>initialize</c>
	/// </summary>
	/// <seealso>Spec 3.16.0</seealso>
	public class SemanticTokenRequestCapabilities {
		/// <summary>
		/// Server supports providing semantic tokens for a specific range of a document.
		/// </summary>
		public bool? range { get; set; }

		/// <summary>
		/// Server supports providing semantic tokens for a full document.
		/// </summary>
		public SemanticTokenFullDocument full { get; set; }
	}
}
