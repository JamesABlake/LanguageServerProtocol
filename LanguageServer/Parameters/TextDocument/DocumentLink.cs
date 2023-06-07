using System;

namespace LanguageServer.Parameters.TextDocument {
	public class DocumentLink {
		public Range range { get; set; }

		public Uri target { get; set; }
	}
}
