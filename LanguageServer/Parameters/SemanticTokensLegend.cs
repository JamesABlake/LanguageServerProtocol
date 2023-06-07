namespace LanguageServer.Parameters {
	public class SemanticTokensLegend {
		/// <summary>
		/// The token types a server uses.
		/// </summary>
		public string[] tokenTypes { get; set; }
		/// <summary>
		/// The token modifiers a server uses.
		/// </summary>
		public string[] tokenModifiers { get; set; }
	}
}
