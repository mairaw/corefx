// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.IO.Compression
{
    /// <summary>
    /// Provides static methods for creating, extracting, and opening zip archives.
    /// </summary>
    public static partial class ZipFile
    {
        /// <summary>
        /// Creates a zip archive that contains the files and directories from the specified directory.
        /// </summary>
        /// <param name="sourceDirectoryName">
        /// The path to the directory to be archived, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="destinationArchiveFileName">
        /// The path of the archive to be created, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is <see cref="String.Empty" />, contains only white space, or contains at least one
        /// invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />,
        /// the specified path, file name, or both exceed the system-defined maximum length. For example,
        /// on Windows-based platforms, paths must not exceed 248 characters, and file names must not
        /// exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="sourceDirectoryName" /> is invalid or does not exist (for example, it is on
        /// an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="destinationArchiveFileName" /> already exists.-or-A file in the specified
        /// directory could not be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="destinationArchiveFileName" /> specifies a directory.-or-The caller does not
        /// have the required permission to access the directory specified in <paramref name="sourceDirectoryName" />
        /// or the file specified in <paramref name="destinationArchiveFileName" />.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// contains an invalid format.-or-The zip archive does not support writing.
        /// </exception>
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) { }
        /// <summary>
        /// Creates a zip archive that contains the files and directories from the specified directory,
        /// uses the specified compression level, and optionally includes the base directory.
        /// </summary>
        /// <param name="sourceDirectoryName">
        /// The path to the directory to be archived, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="destinationArchiveFileName">
        /// The path of the archive to be created, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression effectiveness
        /// when creating the entry.
        /// </param>
        /// <param name="includeBaseDirectory">
        /// true to include the directory name from <paramref name="sourceDirectoryName" /> at the root
        /// of the archive; false to include only the contents of the directory.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is <see cref="String.Empty" />, contains only white space, or contains at least one
        /// invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />,
        /// the specified path, file name, or both exceed the system-defined maximum length. For example,
        /// on Windows-based platforms, paths must not exceed 248 characters, and file names must not
        /// exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="sourceDirectoryName" /> is invalid or does not exist (for example, it is on
        /// an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="destinationArchiveFileName" /> already exists.-or-A file in the specified
        /// directory could not be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="destinationArchiveFileName" /> specifies a directory.-or-The caller does not
        /// have the required permission to access the directory specified in <paramref name="sourceDirectoryName" />
        /// or the file specified in <paramref name="destinationArchiveFileName" />.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// contains an invalid format.-or-The zip archive does not support writing.
        /// </exception>
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory) { }
        /// <summary>
        /// Creates a zip archive that contains the files and directories from the specified directory,
        /// uses the specified compression level and character encoding for entry names, and optionally includes
        /// the base directory.
        /// </summary>
        /// <param name="sourceDirectoryName">
        /// The path to the directory to be archived, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="destinationArchiveFileName">
        /// The path of the archive to be created, specified as a relative or absolute path. A relative
        /// path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression effectiveness
        /// when creating the entry.
        /// </param>
        /// <param name="includeBaseDirectory">
        /// true to include the directory name from <paramref name="sourceDirectoryName" /> at the root
        /// of the archive; false to include only the contents of the directory.
        /// </param>
        /// <param name="entryNameEncoding">
        /// The encoding to use when reading or writing entry names in this archive. Specify a value for
        /// this parameter only when an encoding is required for interoperability with zip archive tools and libraries
        /// that do not support UTF-8 encoding for entry names.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is <see cref="String.Empty" />, contains only white space, or contains at least one
        /// invalid character.-or-<paramref name="entryNameEncoding" /> is set to a Unicode encoding other
        /// than UTF-8.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />,
        /// the specified path, file name, or both exceed the system-defined maximum length. For example,
        /// on Windows-based platforms, paths must not exceed 248 characters, and file names must not
        /// exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="sourceDirectoryName" /> is invalid or does not exist (for example, it is on
        /// an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="destinationArchiveFileName" /> already exists.-or-A file in the specified
        /// directory could not be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="destinationArchiveFileName" /> specifies a directory.-or-The caller does not
        /// have the required permission to access the directory specified in <paramref name="sourceDirectoryName" />
        /// or the file specified in <paramref name="destinationArchiveFileName" />.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="sourceDirectoryName" /> or <paramref name="destinationArchiveFileName" />
        /// contains an invalid format.-or-The zip archive does not support writing.
        /// </exception>
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding entryNameEncoding) { }
        /// <summary>
        /// Extracts all the files in the specified zip archive to a directory on the file system.
        /// </summary>
        /// <param name="sourceArchiveFileName">The path to the archive that is to be extracted.</param>
        /// <param name="destinationDirectoryName">
        /// The path to the directory in which to place the extracted files, specified as a relative or
        /// absolute path. A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// is <see cref="String.Empty" />, contains only white space, or contains at least one
        /// invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// The specified path in <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// exceeds the system-defined maximum length. For example, on Windows-based platforms, paths
        /// must not exceed 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// The directory specified by <paramref name="destinationDirectoryName" /> already exists.-or-The
        /// name of an entry in the archive is <see cref="String.Empty" />, contains only white
        /// space, or contains at least one invalid character.-or-Extracting an archive entry would create
        /// a file that is outside the directory specified by <paramref name="destinationDirectoryName" />.
        /// (For example, this might happen if the entry name contains parent directory accessors.)
        /// -or-An archive entry to extract has the same name as an entry that has already been extracted
        /// from the same archive.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The caller does not have the required permission to access the archive or the destination directory.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// contains an invalid format.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// <paramref name="sourceArchiveFileName" /> was not found.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The archive specified by <paramref name="sourceArchiveFileName" /> is not a valid zip archive.-or-An
        /// archive entry was not found or was corrupt.-or-An archive entry was compressed by using a
        /// compression method that is not supported.
        /// </exception>
        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }
        /// <summary>
        /// Extracts all the files in the specified zip archive to a directory on the file system and uses
        /// the specified character encoding for entry names.
        /// </summary>
        /// <param name="sourceArchiveFileName">The path to the archive that is to be extracted.</param>
        /// <param name="destinationDirectoryName">
        /// The path to the directory in which to place the extracted files, specified as a relative or
        /// absolute path. A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="entryNameEncoding">
        /// The encoding to use when reading or writing entry names in this archive. Specify a value for
        /// this parameter only when an encoding is required for interoperability with zip archive tools and libraries
        /// that do not support UTF-8 encoding for entry names.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// is <see cref="String.Empty" />, contains only white space, or contains at least one
        /// invalid character.-or-<paramref name="entryNameEncoding" /> is set to a Unicode encoding other
        /// than UTF-8.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// The specified path in <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// exceeds the system-defined maximum length. For example, on Windows-based platforms, paths
        /// must not exceed 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// The directory specified by <paramref name="destinationDirectoryName" /> already exists.-or-The
        /// name of an entry in the archive is <see cref="String.Empty" />, contains only white
        /// space, or contains at least one invalid character.-or-Extracting an archive entry would create
        /// a file that is outside the directory specified by <paramref name="destinationDirectoryName" />.
        /// (For example, this might happen if the entry name contains parent directory accessors.)
        /// -or-An archive entry to extract has the same name as an entry that has already been extracted
        /// from the same archive.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The caller does not have the required permission to access the archive or the destination directory.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="destinationDirectoryName" /> or <paramref name="sourceArchiveFileName" />
        /// contains an invalid format.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// <paramref name="sourceArchiveFileName" /> was not found.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The archive specified by <paramref name="sourceArchiveFileName" /> is not a valid zip archive.-or-An
        /// archive entry was not found or was corrupt.-or-An archive entry was compressed by using a
        /// compression method that is not supported.
        /// </exception>
        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, System.Text.Encoding entryNameEncoding) { }
        /// <summary>
        /// Opens a zip archive at the specified path and in the specified mode.
        /// </summary>
        /// <param name="archiveFileName">
        /// The path to the archive to open, specified as a relative or absolute path. A relative path
        /// is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="mode">
        /// One of the enumeration values that specifies the actions which are allowed on the entries in
        /// the opened archive.
        /// </param>
        /// <returns>
        /// The opened zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="archiveFileName" /> is <see cref="String.Empty" />, contains only
        /// white space, or contains at least one invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="archiveFileName" /> is null.</exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="archiveFileName" />, the specified path, file name, or both exceed the
        /// system-defined maximum length. For example, on Windows-based platforms, paths must not exceed
        /// 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="archiveFileName" /> is invalid or does not exist (for example, it is on an
        /// unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="archiveFileName" /> could not be opened.-or-<paramref name="mode" /> is set
        /// to <see cref="Compression.ZipArchiveMode.Create" />, but the file specified in
        /// <paramref name="archiveFileName" /> already exists.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="archiveFileName" /> specifies a directory.-or-The caller does not have the
        /// required permission to access the file specified in <paramref name="archiveFileName" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="mode" /> specifies an invalid value.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// <paramref name="mode" /> is set to <see cref="Compression.ZipArchiveMode.Read" />,
        /// but the file specified in <paramref name="archiveFileName" /> is not found.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="archiveFileName" /> contains an invalid format.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// <paramref name="archiveFileName" /> could not be interpreted as a zip archive.-or-<paramref name="mode" />
        /// is <see cref="Compression.ZipArchiveMode.Update" />, but an entry
        /// is missing or corrupt and cannot be read.-or-<paramref name="mode" /> is
        /// <see cref="Compression.ZipArchiveMode.Update" />, but an entry is too large to fit into memory.
        /// </exception>
        public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode) { return default(System.IO.Compression.ZipArchive); }
        /// <summary>
        /// Opens a zip archive at the specified path, in the specified mode, and by using the specified
        /// character encoding for entry names.
        /// </summary>
        /// <param name="archiveFileName">
        /// The path to the archive to open, specified as a relative or absolute path. A relative path
        /// is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="mode">
        /// One of the enumeration values that specifies the actions that are allowed on the entries in
        /// the opened archive.
        /// </param>
        /// <param name="entryNameEncoding">
        /// The encoding to use when reading or writing entry names in this archive. Specify a value for
        /// this parameter only when an encoding is required for interoperability with zip archive tools and libraries
        /// that do not support UTF-8 encoding for entry names.
        /// </param>
        /// <returns>
        /// The opened zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="archiveFileName" /> is <see cref="String.Empty" />, contains only
        /// white space, or contains at least one invalid character.-or-<paramref name="entryNameEncoding" />
        /// is set to a Unicode encoding other than UTF-8.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="archiveFileName" /> is null.</exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="archiveFileName" />, the specified path, file name, or both exceed the
        /// system-defined maximum length. For example, on Windows-based platforms, paths must not exceed
        /// 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="archiveFileName" /> is invalid or does not exist (for example, it is on an
        /// unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="archiveFileName" /> could not be opened.-or-<paramref name="mode" /> is set
        /// to <see cref="Compression.ZipArchiveMode.Create" />, but the file specified in
        /// <paramref name="archiveFileName" /> already exists.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="archiveFileName" /> specifies a directory.-or-The caller does not have the
        /// required permission to access the file specified in <paramref name="archiveFileName" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="mode" /> specifies an invalid value.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// <paramref name="mode" /> is set to <see cref="Compression.ZipArchiveMode.Read" />,
        /// but the file specified in <paramref name="archiveFileName" /> is not found.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="archiveFileName" /> contains an invalid format.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// <paramref name="archiveFileName" /> could not be interpreted as a zip archive.-or-<paramref name="mode" />
        /// is <see cref="Compression.ZipArchiveMode.Update" />, but an entry
        /// is missing or corrupt and cannot be read.-or-<paramref name="mode" /> is
        /// <see cref="Compression.ZipArchiveMode.Update" />, but an entry is too large to fit into memory.
        /// </exception>
        public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode, System.Text.Encoding entryNameEncoding) { return default(System.IO.Compression.ZipArchive); }
        /// <summary>
        /// Opens a zip archive for reading at the specified path.
        /// </summary>
        /// <param name="archiveFileName">
        /// The path to the archive to open, specified as a relative or absolute path. A relative path
        /// is interpreted as relative to the current working directory.
        /// </param>
        /// <returns>
        /// The opened zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="archiveFileName" /> is <see cref="String.Empty" />, contains only
        /// white space, or contains at least one invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="archiveFileName" /> is null.</exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="archiveFileName" />, the specified path, file name, or both exceed the
        /// system-defined maximum length. For example, on Windows-based platforms, paths must not exceed
        /// 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="archiveFileName" /> is invalid or does not exist (for example, it is on an
        /// unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="archiveFileName" /> could not be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="archiveFileName" /> specifies a directory.-or-The caller does not have the
        /// required permission to access the file specified in <paramref name="archiveFileName" />.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// The file specified in <paramref name="archiveFileName" /> is not found.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="archiveFileName" /> contains an invalid format.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// <paramref name="archiveFileName" /> could not be interpreted as a zip archive.
        /// </exception>
        public static System.IO.Compression.ZipArchive OpenRead(string archiveFileName) { return default(System.IO.Compression.ZipArchive); }
    }
    /// <summary>
    /// Provides extension methods for the <see cref="Compression.ZipArchive" /> and
    /// <see cref="Compression.ZipArchiveEntry" /> classes.
    /// </summary>
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class ZipFileExtensions
    {
        /// <summary>
        /// Archives a file by compressing it and adding it to the zip archive.
        /// </summary>
        /// <param name="destination">The zip archive to add the file to.</param>
        /// <param name="sourceFileName">
        /// The path to the file to be archived. You can specify either a relative or an absolute path.
        /// A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="entryName">The name of the entry to create in the zip archive.</param>
        /// <returns>
        /// A wrapper for the new entry in the zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="sourceFileName" /> is <see cref="String.Empty" />, contains only
        /// white space, or contains at least one invalid character.-or-<paramref name="entryName" />
        /// is <see cref="String.Empty" />.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sourceFileName" /> or <paramref name="entryName" /> is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="sourceFileName" />, the specified path, file name, or both exceed the system-defined
        /// maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters,
        /// and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="sourceFileName" /> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// The file specified by <paramref name="sourceFileName" /> cannot be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="sourceFileName" /> specifies a directory.-or-The caller does not have the
        /// required permission to access the file specified by <paramref name="sourceFileName" />.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// The file specified by <paramref name="sourceFileName" /> is not found.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <paramref name="sourceFileName" /> parameter is in an invalid format.-or-The zip archive
        /// does not support writing.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
        /// <summary>
        /// Archives a file by compressing it using the specified compression level and adding it to the
        /// zip archive.
        /// </summary>
        /// <param name="destination">The zip archive to add the file to.</param>
        /// <param name="sourceFileName">
        /// The path to the file to be archived. You can specify either a relative or an absolute path.
        /// A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="entryName">The name of the entry to create in the zip archive.</param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression effectiveness
        /// when creating the entry.
        /// </param>
        /// <returns>
        /// A wrapper for the new entry in the zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="sourceFileName" /> is <see cref="String.Empty" />, contains only
        /// white space, or contains at least one invalid character.-or-<paramref name="entryName" />
        /// is <see cref="String.Empty" />.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="sourceFileName" /> or <paramref name="entryName" /> is null.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// <paramref name="sourceFileName" /> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// In <paramref name="sourceFileName" />, the specified path, file name, or both exceed the system-defined
        /// maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters,
        /// and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="IOException">
        /// The file specified by <paramref name="sourceFileName" /> cannot be opened.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// <paramref name="sourceFileName" /> specifies a directory.-or-The caller does not have the
        /// required permission to access the file specified by <paramref name="sourceFileName" />.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// The file specified by <paramref name="sourceFileName" /> is not found.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <paramref name="sourceFileName" /> parameter is in an invalid format.-or-The zip archive
        /// does not support writing.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
        /// <summary>
        /// Extracts all the files in the zip archive to a directory on the file system.
        /// </summary>
        /// <param name="source">The zip archive to extract files from.</param>
        /// <param name="destinationDirectoryName">
        /// The path to the directory to place the extracted files in. You can specify either a relative
        /// or an absolute path. A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="destinationDirectoryName" /> is <see cref="String.Empty" />, contains
        /// only white space, or contains at least one invalid character.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="destinationDirectoryName" /> is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// The specified path exceeds the system-defined maximum length. For example, on Windows-based
        /// platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// The directory specified by <paramref name="destinationDirectoryName" /> already exists.-or-The
        /// name of an entry in the archive is <see cref="String.Empty" />, contains only white
        /// space, or contains at least one invalid character.-or-Extracting an entry from the archive
        /// would create a file that is outside the directory specified by <paramref name="destinationDirectoryName" />.
        /// (For example, this might happen if the entry name contains parent directory accessors.)
        /// -or-Two or more entries in the archive have the same name.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The caller does not have the required permission to write to the destination directory.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="destinationDirectoryName" /> contains an invalid format.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// An archive entry cannot be found or is corrupt.-or-An archive entry was compressed by using
        /// a compression method that is not supported.
        /// </exception>
        public static void ExtractToDirectory(this System.IO.Compression.ZipArchive source, string destinationDirectoryName) { }
        /// <summary>
        /// Extracts an entry in the zip archive to a file.
        /// </summary>
        /// <param name="source">The zip archive entry to extract a file from.</param>
        /// <param name="destinationFileName">
        /// The path of the file to create from the contents of the entry. You can  specify either a relative
        /// or an absolute path. A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="destinationFileName" /> is a zero-length string, contains only white space,
        /// or contains one or more invalid characters as defined by <see cref="Path.InvalidPathChars" />.
        /// -or-<paramref name="destinationFileName" /> specifies a directory.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="destinationFileName" /> is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// The specified path, file name, or both exceed the system-defined maximum length. For example,
        /// on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed
        /// 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="destinationFileName" /> already exists.-or- An I/O error occurred.-or-The
        /// entry is currently open for writing.-or-The entry has been deleted from the archive.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The caller does not have the required permission to create the new file.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The entry is missing from the archive, or is corrupt and cannot be read.-or-The entry has been
        /// compressed by using a compression method that is not supported.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// The zip archive that this entry belongs to has been disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="destinationFileName" /> is in an invalid format. -or-The zip archive for this
        /// entry was opened in <see cref="Compression.ZipArchiveMode.Create" /> mode, which
        /// does not permit the retrieval of entries.
        /// </exception>
        public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName) { }
        /// <summary>
        /// Extracts an entry in the zip archive to a file, and optionally overwrites an existing file
        /// that has the same name.
        /// </summary>
        /// <param name="source">The zip archive entry to extract a file from.</param>
        /// <param name="destinationFileName">
        /// The path of the file to create from the contents of the entry. You can specify either a relative
        /// or an absolute path. A relative path is interpreted as relative to the current working directory.
        /// </param>
        /// <param name="overwrite">
        /// true to overwrite an existing file that has the same name as the destination file; otherwise,
        /// false.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="destinationFileName" /> is a zero-length string, contains only white space,
        /// or contains one or more invalid characters as defined by <see cref="Path.InvalidPathChars" />.
        /// -or-<paramref name="destinationFileName" /> specifies a directory.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="destinationFileName" /> is null.
        /// </exception>
        /// <exception cref="PathTooLongException">
        /// The specified path, file name, or both exceed the system-defined maximum length. For example,
        /// on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed
        /// 260 characters.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="IOException">
        /// <paramref name="destinationFileName" /> already exists and <paramref name="overwrite" /> is
        /// false.-or- An I/O error occurred.-or-The entry is currently open for writing.-or-The entry
        /// has been deleted from the archive.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The caller does not have the required permission to create the new file.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The entry is missing from the archive or is corrupt and cannot be read.-or-The entry has been
        /// compressed by using a compression method that is not supported.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// The zip archive that this entry belongs to has been disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <paramref name="destinationFileName" /> is in an invalid format. -or-The zip archive for this
        /// entry was opened in <see cref="Compression.ZipArchiveMode.Create" /> mode, which
        /// does not permit the retrieval of entries.
        /// </exception>
        public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
    }
}
