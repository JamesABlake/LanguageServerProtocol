using System;

namespace LanguageServer.Parameters.TextDocument {
	public class TextDocumentItem {
		public Uri uri { get; set; }

		public string languageId { get; set; }

		public long version { get; set; }

		public string text { get; set; }
	}
}
