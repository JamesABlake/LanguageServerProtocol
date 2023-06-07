using LanguageServer.Infrastructure.JsonDotNet;
using System;

namespace LanguageServer.Json {
	public abstract class Serializer {
		public abstract object Deserialize(Type objectType, string json);

		public abstract string Serialize(Type objectType, object value);

		public static Serializer Instance { get; set; } = new JsonDotNetSerializer();
	}
}
