namespace LanguageServer.Parameters.General {

	/// <summary>
	/// A notification that should be used by the client to modify the trace setting of the server.
	/// </summary>
	/// <remarks>For <c>setTrace</c>.</remarks>
	public class SetTraceParams {
		public string value { get; set; }
	}
}
