using System;

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
		public static void createFile() { }

		/**
		 * Import a csv file into the project.
		 * Checks that the csv file is compatible with the application.
		 */
		public static void importFile() { }

		/**
		 * Save changes into file.
		 */
		public static void saveFile() { }

		/**
		 * Save changes into the file name defined by the user.
		 */
		public static void saveFileAs() { }

		private static bool canChangeFile() {
			return false;	
		}
	}
}
