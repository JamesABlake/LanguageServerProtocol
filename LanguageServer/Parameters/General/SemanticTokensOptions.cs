namespace LanguageServer.Parameters.General {
	public class SemanticTokensOptions {
		/// <summary>
		/// The legend used by the server
		/// </summary>
		public SemanticTokensLegend legend { get; set; }

		/// <summary>
		/// Server supports providing semantic tokens for a specific range of a document.
		/// </summary>
		public bool? range { get; set; }

		/// <summary>
		/// Server supports providing semantic tokens for a full document.
		/// </summary>
		public bool? full { get; set; }
	}
}
