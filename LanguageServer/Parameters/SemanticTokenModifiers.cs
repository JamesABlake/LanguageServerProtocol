namespace LanguageServer.Parameters {
	/// <summary>
	/// For <c>textDocument/semanticTokens</c> 
	/// </summary>
	/// <seealso>Spec 3.16.0</seealso>
	public static class SemanticTokenModifiers {
		/// <summary>Declaration</summary>
		public const string Declaration = "declaration";
		/// <summary>Definition</summary>
		public const string Definition = "definition";
		/// <summary>Readonly</summary>
		public const string Readonly = "readonly";
		/// <summary>Static</summary>
		public const string Static = "static";
		/// <summary>Deprecated</summary>
		public const string Deprecated = "deprecated";
		/// <summary>Abstract</summary>
		public const string Abstract = "abstract";
		/// <summary>Async</summary>
		public const string Async = "async";
		/// <summary>Modification</summary>
		public const string Modification = "modification";
		/// <summary>Documentation</summary>
		public const string Documentation = "documentation";
		/// <summary>DefaultLibrary</summary>
		public const string DefaultLibrary = "defaultLibrary";
	}
}