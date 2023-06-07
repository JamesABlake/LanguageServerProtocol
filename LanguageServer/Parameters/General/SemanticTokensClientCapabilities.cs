namespace LanguageServer.Parameters.General {

	/// <summary>
	/// For <c>initialize</c>
	/// </summary>
	/// <seealso>Spec 3.16.0</seealso>
#pragma warning disable IDE1006 // Naming Styles
	public class SemanticTokensCapabilities : RegistrationCapabilities {

		/// <summary>
		/// Which requests the client supports and might send to the server
		/// depending on the server's capability. Please note that clients might not
		/// show semantic tokens or degrade some of the user experience if a range
		/// or full request is advertised by the client but not provided by the
		/// server.If for example the client capability <c>requests.full</c> and
		/// <c>request.range</c> are both set to true but the server only provides a
		/// range provider the client might not render a minimap correctly or might
		/// even decide to not show any semantic tokens at all.
		/// </summary>
		/// <seealso>Spec 3.16.0</seealso>
		public SemanticTokenRequestCapabilities requests { get; set; }

		/// <summary>
		/// The token types that the client supports.
		/// </summary>
		/// <value>
		/// See <see cref="LanguageServer.Parameters.SemanticTokenTypes"/> for an enumeration of standardized types.
		/// </value>
		/// <seealso>Spec 3.16.0</seealso>
		/// <see cref="LanguageServer.Parameters.SemanticTokenTypes"/>
		public string[] tokenTypes { get; set; }

		/// <summary>
		/// The token modifiers that the client supports.
		/// </summary>
		/// <value>
		/// See <see cref="LanguageServer.Parameters.SemanticTokenModifiers"/> for an enumeration of standardized modifiers.
		/// </value>
		/// <seealso>Spec 3.16.0</seealso>
		/// <see cref="LanguageServer.Parameters.SemanticTokenModifiers"/>
		public string[] tokenModifiers { get; set; }

		/// <summary>
		/// The formats the clients supports.
		/// </summary>
		/// <value>
		/// See <see cref="LanguageServer.Parameters.TokenFormat"/> for an enumeration of standardized formats.
		/// </value>
		/// <seealso>Spec 3.16.0</seealso>
		/// <seealso cref="LanguageServer.Parameters.TokenFormat"/>
		public string[] formats { get; set; }

		/// <summary>
		/// Whether the client supports tokens that can overlap each other.
		/// </summary>
		public bool? overlappingTokenSupport { get; set; }

		/// <summary>
		/// Whether the client supports tokens that can span multiple lines.
		/// </summary>
		public bool? multilineTokenSupport { get; set; }
	}
#pragma warning restore IDE1006 // Naming Styles
}
