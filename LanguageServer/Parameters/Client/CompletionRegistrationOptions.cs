﻿namespace LanguageServer.Parameters.Client {
	/// <summary>
	/// For <c>client/registerCapability</c>
	/// </summary>
	public class CompletionRegistrationOptions : TextDocumentRegistrationOptions {
		public string[] triggerCharacters { get; set; }

		public bool? resolveProvider { get; set; }
	}
}
