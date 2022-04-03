using System;
using System.IO;
using System.Text;

namespace LexiconApplication
{
	public class FileControl {
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
			return true;
		}

		/**
		 * Save changes into the file name defined by the user.
		 */
		public static bool saveFileAs() {
			return true;
		}

		private static bool canChangeFile() {
			return false;	
		}
	}
}
