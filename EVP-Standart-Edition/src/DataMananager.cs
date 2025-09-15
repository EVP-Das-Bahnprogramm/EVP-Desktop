using System.Xml.Serialization;

namespace EVP
{
	public class User
	{
		public string Username { get; set; }

		// Optional: for web sighting system
		public string AccountEmail { get; set; }
		public string AuthToken { get; set; }

		public bool IsWebLinked =>
			!string.IsNullOrEmpty(AccountEmail) &&
			!string.IsNullOrEmpty(AuthToken);
	}

	public static class DataManager
	{
		public static readonly string BasePath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			"evp-bahnprogramm"
		);

		private static string SavedDataPath => Path.Combine(BasePath, "saveddata.xml");
		private static string SavedPlacesPath => Path.Combine(BasePath, "savedplaces.xml");
		private static string UserPath => Path.Combine(BasePath, "user.xml");

		public static void InitializeStructure()
		{
			Directory.CreateDirectory(BasePath);

			CreateEmptyXml(SavedDataPath, new List<string>());
			CreateEmptyXml(SavedPlacesPath, new List<string>());
			CreateEmptyXml(UserPath, new User { Username = "default" });
		}

		public static void RepairStructure()
		{
			InitializeStructure(); // Safe to re-run
		}

		public static void AddSavedLink(string url)
		{
			var list = LoadXml<List<string>>(SavedDataPath) ?? new List<string>();
			list.Add(url);
			SaveXml(SavedDataPath, list);
		}

		public static void AddSavedPlace(string place)
		{
			var list = LoadXml<List<string>>(SavedPlacesPath) ?? new List<string>();
			list.Add(place);
			SaveXml(SavedPlacesPath, list);
		}

		public static List<string> LoadSavedPlaces()
		{
			return LoadXml<List<string>>(SavedPlacesPath) ?? new List<string>();
		}

		public static List<string> LoadSavedLinks()
		{
			return LoadXml<List<string>>(SavedDataPath) ?? new List<string>();
		}

		public static User LoadUser()
		{
			return LoadXml<User>(UserPath) ?? new User { Username = "default" };
		}

		public static void SaveUser(User user)
		{
			SaveXml(UserPath, user);
		}

		private static void CreateEmptyXml<T>(string path, T defaultValue)
		{
			if (!File.Exists(path))
				SaveXml(path, defaultValue);
		}

		private static T LoadXml<T>(string path)
		{
			if (!File.Exists(path)) return default;
			var serializer = new XmlSerializer(typeof(T));
			using var fs = new FileStream(path, FileMode.Open);
			return (T)serializer.Deserialize(fs);
		}

		private static void SaveXml<T>(string path, T data)
		{
			var serializer = new XmlSerializer(typeof(T));
			using var fs = new FileStream(path, FileMode.Create);
			serializer.Serialize(fs, data);
		}
	}
}
