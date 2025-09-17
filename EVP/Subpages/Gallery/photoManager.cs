using EVP;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Xml.Serialization;

public class ImageInfo
{
	public string TrainClass { get; set; }
	public string FullClass { get; set; }
	public string PlaceTaken { get; set; }
	public string TrainName { get; set; }
	public string TrainCompany { get; set; }
	public string Country { get; set; }
	public string TrainType { get; set; } // Diesel, Electric, etc.
	public string Coaches { get; set; }
	public bool MultipleUnit { get; set; }

	public DateTime DateTaken { get; set; }
	public string CameraModel { get; set; }
	public string LensInfo { get; set; }
}

public static class EVPDataManager
{
	private static readonly string BasePath = Path.Combine(
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
		"evp-bahnprogramm"
	);

	private static string GalleryPath => Path.Combine(BasePath, "gallery");
	private static string PluginsPath => Path.Combine(BasePath, "plugins");

	private static string PicListPath => Path.Combine(GalleryPath, "piclist.xml");
	private static string PluginListPath => Path.Combine(PluginsPath, "list.xml");
	private static string SavedDataPath => Path.Combine(BasePath, "saveddata.xml");
	private static string SavedPlacesPath => Path.Combine(BasePath, "savedplaces.xml");
	private static string UserPath => Path.Combine(BasePath, "user.xml");

	public static void InitializeStructure()
	{
		System.IO.Directory.CreateDirectory(BasePath);
		System.IO.Directory.CreateDirectory(GalleryPath);
		System.IO.Directory.CreateDirectory(PluginsPath);

		CreateEmptyXml(PicListPath, new List<string>());
		CreateEmptyXml(PluginListPath, new List<string>());
		CreateEmptyXml(SavedDataPath, new List<string>());
		CreateEmptyXml(SavedPlacesPath, new List<string>());
		CreateEmptyXml(UserPath, new User { Username = "default"});
	}

	public static void RepairStructure()
	{
		InitializeStructure(); // Safe to re-run
	}

	public static void AddImage(string imageSourcePath, ImageInfo info)
	{
		string imageId = GenerateNextImageId();
		string imageFolder = Path.Combine(GalleryPath, imageId);
		System.IO.Directory.CreateDirectory(imageFolder);

		string extension = Path.GetExtension(imageSourcePath);
		string destImagePath = Path.Combine(imageFolder, "img" + extension);
		System.IO.File.Copy(imageSourcePath, destImagePath, overwrite: true);

		var metadata = ExtractMetadata(imageSourcePath);
		info.DateTaken = metadata.DateTaken;
		info.CameraModel = metadata.CameraModel;
		info.LensInfo = metadata.LensInfo;

		info.FullClass = $"{info.TrainCompany} {info.TrainClass} ({info.TrainType})";
		info.TrainName = LookupTrainName(info.TrainClass);

		SaveXml(Path.Combine(imageFolder, "info.xml"), info);

		var list = LoadXml<List<string>>(PicListPath) ?? new List<string>();
		list.Add(imageId);
		SaveXml(PicListPath, list);
	}

	public static void AddPlugin(string pluginName)
	{
		string folder = Path.Combine(PluginsPath, pluginName);
		System.IO.Directory.CreateDirectory(folder);

		var list = LoadXml<List<string>>(PluginListPath) ?? new List<string>();
		if (!list.Contains(pluginName)) list.Add(pluginName);
		SaveXml(PluginListPath, list);
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

	public static ImageInfo ExtractMetadata(string imagePath)
	{
		var info = new ImageInfo();
		var directories = ImageMetadataReader.ReadMetadata(imagePath);

		var exif = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
		if (exif != null)
		{
			info.DateTaken = exif.GetDateTime(ExifDirectoryBase.TagDateTimeOriginal);
			info.CameraModel = exif.GetDescription(ExifDirectoryBase.TagModel);
			info.LensInfo = exif.GetDescription(ExifDirectoryBase.TagLensModel);
		}

		return info;
	}

	public static string LookupTrainName(string trainClass)
	{
		// Placeholder logic — replace with real DB lookup
		var db = new Dictionary<string, string>
		{
			{ "402", "ICE 2" },
			{ "401", "ICE 1" },
			{ "403", "ICE 3" }
		};

		return db.TryGetValue(trainClass, out var name) ? name : "Unknown";
	}

	private static string GenerateNextImageId()
	{
		var list = LoadXml<List<string>>(PicListPath) ?? new List<string>();
		int nextId = list.Count + 1;
		return $"IMG_{nextId:D4}";
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
