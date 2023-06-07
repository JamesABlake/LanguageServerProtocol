namespace LanguageServer.Parameters.TextDocument {
	public class Command {
		public string title { get; set; }

		public string command { get; set; }

		public dynamic[] arguments { get; set; }
	}
}
