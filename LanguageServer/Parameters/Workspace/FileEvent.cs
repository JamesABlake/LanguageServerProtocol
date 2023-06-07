using System;

namespace LanguageServer.Parameters.Workspace {
	public class FileEvent {
		public Uri uri { get; set; }
		public FileChangeType type { get; set; }
	}
}
