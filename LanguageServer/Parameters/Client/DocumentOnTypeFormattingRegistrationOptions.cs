﻿namespace LanguageServer.Parameters.Client {
	/// <summary>
	/// For <c>client/registerCapability</c>
	/// </summary>
	public class DocumentOnTypeFormattingRegistrationOptions : TextDocumentRegistrationOptions {
		public string firstTriggerCharacter { get; set; }

		public string[] moreTriggerCharacter { get; set; }
	}
}
