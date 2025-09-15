using EVP;
using System.Xml.Serialization;

public class User
{
	public string Username { get; set; }
	public string Language { get; set; }
}

public static class UserManager
{
	private static string filePath = Program.userDataFolderPath + "users.xml";

	public static List<User> LoadUsers()
	{
		if (!File.Exists(filePath))
			return new List<User>();

		XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
		using (FileStream fs = new FileStream(filePath, FileMode.Open))
		{
			return (List<User>)serializer.Deserialize(fs);
		}
	}

	public static void SaveUsers(List<User> users)
	{
		XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
		using (FileStream fs = new FileStream(filePath, FileMode.Create))
		{
			serializer.Serialize(fs, users);
		}
	}
}