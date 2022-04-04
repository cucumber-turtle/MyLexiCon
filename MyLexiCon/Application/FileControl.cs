using System;
using System.IO;
using System.Text;

namespace LexiconApplication
{
	public class FileControl {
		private static String fileName;
		private static String filePath;
		private static String langName;
		private static String langVersion;
		private static String langFont;
		private static bool fileChanged;

		public FileControl() { }
		/**
		 * Method for creating a new CSV file, given:
		 * - File name
		 * - File path
		 * - Language name
		 * - Language version (optional)
		 * - Language font (optional)
		 * Also adds columns for word, pronunciation, romanisation, and definition.
		 */
		public static void createFile(String fileName, String path, String langName,
						String langVersion = "1.0", String langFont = null) {
			try
            {
				using (FileStream stream = File.Create(path + "/" + fileName + ".csv"))
                {
					String header = langName + "," + "version " + langVersion+"\n";
					String columns = "Word,Pronunciation,Romanisation,Definition \n";
					byte[] encodedHeader = new UTF8Encoding(header + columns);
					stream.Write(encodedHeader, 0, encodedHeader.Length);
                }
				this.fileName = fileName;
				this.filePath = path;
				this.langName = langName;
				this.langVersion = langVersion;
				this.langFont = langFont;
				this.fileChanged = false;

			} catch (Exception e)
            {
				Console.WriteLine(e.StackTrace); // printing call stack for testing purposes
            }
		}

		/**
		 * Import a csv file into the project.
		 * Checks that the csv file is compatible with the application.
		 */
		public static void importFile() { }

		/**
		 * Save changes into file.
		 */
		public static bool saveFile() {
			this.fileChanged = false;
			return true;
		}

		/**
		 * Save changes into the file name defined by the user.
		 */
		public static bool saveFileAs() {
			this.fileChanged = false;
			return true;
		}

		private static bool canChangeFile() {
			return !this.fileChanged;
		}
	}
}
