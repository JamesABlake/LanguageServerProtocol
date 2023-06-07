namespace LanguageServer.Parameters {
	/// <summary>
	/// For <c>textDocument/semanticTokens</c> 
	/// </summary>
	/// <remarks>
	/// Represents a generic type. Acts as a fallback for types which
	/// can't be mapped to a specific type like class or enum.
	/// </remarks>
	/// <seealso>Spec 3.16.0</seealso>
	public static class SemanticTokenTypes {
		/// <summary>Namespace</summary>
		public const string Namespace = "namespace";
		/// <summary>Type</summary>
		public const string Type = "type";
		/// <summary>Class</summary>
		public const string Class = "class";
		/// <summary>Enum</summary>
		public const string Enum = "enum";
		/// <summary>Interface</summary>
		public const string Interface = "interface";
		/// <summary>Struct</summary>
		public const string Struct = "struct";
		/// <summary>TypeParameter</summary>
		public const string TypeParameter = "typeParameter";
		/// <summary>Parameter</summary>
		public const string Parameter = "parameter";
		/// <summary>Variable</summary>
		public const string Variable = "variable";
		/// <summary>Property</summary>
		public const string Property = "property";
		/// <summary>EnumMember</summary>
		public const string EnumMember = "enumMember";
		/// <summary>Event</summary>
		public const string Event = "event";
		/// <summary>Function</summary>
		public const string Function = "function";
		/// <summary>Method</summary>
		public const string Method = "method";
		/// <summary>Macro</summary>
		public const string Macro = "macro";
		/// <summary>Keyword</summary>
		public const string Keyword = "keyword";
		/// <summary>Modifier</summary>
		public const string Modifier = "modifier";
		/// <summary>Comment</summary>
		public const string Comment = "comment";
		/// <summary>String</summary>
		public const string String = "string";
		/// <summary>Number</summary>
		public const string Number = "number";
		/// <summary>Regexp</summary>
		public const string Regexp = "regexp";
		/// <summary>Operator</summary>
		public const string Operator = "operator";
		/// <summary>Decorator</summary>
		public const string Decorator = "decorator";
	}
}
