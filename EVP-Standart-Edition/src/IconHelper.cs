using System.Runtime.InteropServices;

namespace EVP.src
{
	public class IconHelper
	{   // IMAGERES: https://renenyffenegger.ch/development/Windows/PowerShell/examples/WinAPI/ExtractIconEx/imageres.html
		// SHELL32: https://renenyffenegger.ch/development/Windows/PowerShell/examples/WinAPI/ExtractIconEx/shell32.html
		public static Icon Extract(string filePath, int index, bool largeIcon = true)
		{
			if (filePath == null)
				throw new ArgumentNullException(nameof(filePath));

			IntPtr hIcon;
			if (largeIcon)
			{
				ExtractIconEx(filePath, index, out hIcon, IntPtr.Zero, 1);
			}
			else
			{
				ExtractIconEx(filePath, index, IntPtr.Zero, out hIcon, 1);
			}

			return hIcon != IntPtr.Zero ? Icon.FromHandle(hIcon) : null;
		}

		[DllImport("shell32", CharSet = CharSet.Unicode)]
		private static extern int ExtractIconEx(string lpszFile, int nIconIndex, out IntPtr phiconLarge, IntPtr phiconSmall, int nIcons);

		[DllImport("shell32", CharSet = CharSet.Unicode)]
		private static extern int ExtractIconEx(string lpszFile, int nIconIndex, IntPtr phiconLarge, out IntPtr phiconSmall, int nIcons);
		public void LoadFileIcon(Control targetControl, int id, bool li, bool useNewIcons)
		{
			string filePath;
			if (useNewIcons == true)
			{
				filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32", "imageres.dll");
			}
			else
			{
				filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32", "shell32.dll");
			}
			if (string.IsNullOrEmpty(filePath))
				throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

			if (targetControl == null)
				throw new ArgumentNullException(nameof(targetControl));

			// Extract the first icon from the specified file
			Icon fileIcon = IconHelper.Extract(filePath, id, li);

			if (fileIcon != null)
			{
				// Check if the control has an Image property
				var property = targetControl.GetType().GetProperty("Image");
				if (property != null && property.PropertyType == typeof(Image))
				{
					property.SetValue(targetControl, fileIcon.ToBitmap());
				}
				else
				{
					throw new InvalidOperationException($"The control of type {targetControl.GetType().Name} does not support an Image property.");
				}
			}
		}

	}

}
