// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.IO.Compression
{
    /// <summary>
    /// Specifies values that indicate whether a compression operation emphasizes speed or compression
    /// size.
    /// </summary>
    public enum CompressionLevel
    {
        /// <summary>
        /// The compression operation should complete as quickly as possible, even if the resulting file
        /// is not optimally compressed.
        /// </summary>
        Fastest = 1,
        /// <summary>
        /// No compression should be performed on the file.
        /// </summary>
        NoCompression = 2,
        /// <summary>
        /// The compression operation should be optimally compressed, even if the operation takes a longer
        /// time to complete.
        /// </summary>
        Optimal = 0,
    }
    /// <summary>
    /// Specifies whether to compress or decompress the underlying stream.
    /// </summary>
    public enum CompressionMode
    {
        /// <summary>
        /// Compresses the underlying stream.
        /// </summary>
        Compress = 1,
        /// <summary>
        /// Decompresses the underlying stream.
        /// </summary>
        Decompress = 0,
    }
    /// <summary>
    /// Provides methods and properties for compressing and decompressing streams by using the Deflate
    /// algorithm.
    /// </summary>
    public partial class DeflateStream : System.IO.Stream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeflateStream" /> class
        /// by using the specified stream and compression level.
        /// </summary>
        /// <param name="stream">The stream to compress.</param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression efficiency
        /// when compressing the stream.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The stream does not support write operations such as compression. (The
        /// <see cref="Stream.CanWrite" /> property on the stream object is false.)
        /// </exception>
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeflateStream" /> class
        /// by using the specified stream and compression level, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream to compress.</param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression efficiency
        /// when compressing the stream.
        /// </param>
        /// <param name="leaveOpen">
        /// true to leave the stream object open after disposing the <see cref="DeflateStream" />
        /// object; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The stream does not support write operations such as compression. (The
        /// <see cref="Stream.CanWrite" /> property on the stream object is false.)
        /// </exception>
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeflateStream" /> class
        /// by using the specified stream and compression mode.
        /// </summary>
        /// <param name="stream">The stream to compress or decompress.</param>
        /// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="mode" /> is not a valid <see cref="CompressionMode" />
        /// value.-or-<see cref="CompressionMode" /> is
        /// <see cref="CompressionMode.Compress" />  and <see cref="Stream.CanWrite" /> is false.-or-
        /// <see cref="CompressionMode" /> is <see cref="CompressionMode.Decompress" />  and
        /// <see cref="Stream.CanRead" /> is false.
        /// </exception>
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeflateStream" /> class
        /// by using the specified stream and compression mode, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream to compress or decompress.</param>
        /// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after disposing the <see cref="DeflateStream" />
        /// object; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="mode" /> is not a valid <see cref="CompressionMode" />
        /// value.-or-<see cref="CompressionMode" /> is
        /// <see cref="CompressionMode.Compress" />  and <see cref="Stream.CanWrite" /> is false.-or-
        /// <see cref="CompressionMode" /> is <see cref="CompressionMode.Decompress" />  and
        /// <see cref="Stream.CanRead" /> is false.
        /// </exception>
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
        /// <summary>
        /// Gets a reference to the underlying stream.
        /// </summary>
        /// <returns>
        /// A stream object that represents the underlying stream.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The underlying stream is closed.</exception>
        public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports reading while decompressing a file.
        /// </summary>
        /// <returns>
        /// true if the <see cref="CompressionMode" /> value is Decompress, and
        /// the underlying stream is opened and supports reading; otherwise, false.
        /// </returns>
        public override bool CanRead { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports seeking.
        /// </summary>
        /// <returns>
        /// false in all cases.
        /// </returns>
        public override bool CanSeek { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports writing.
        /// </summary>
        /// <returns>
        /// true if the <see cref="CompressionMode" /> value is Compress, and
        /// the underlying stream supports writing and is not closed; otherwise, false.
        /// </returns>
        public override bool CanWrite { get { return default(bool); } }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Length { get { return default(long); } }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Position { get { return default(long); } set { } }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="DeflateStream" />
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// The current implementation of this method has no functionality.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override void Flush() { }
        /// <summary>
        /// Reads a number of decompressed bytes into the specified byte array.
        /// </summary>
        /// <param name="array">The array to store decompressed bytes.</param>
        /// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
        /// <param name="count">The maximum number of decompressed bytes to read.</param>
        /// <returns>
        /// The number of bytes that were read into the byte array.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="CompressionMode" /> value was Compress when the object
        /// was created.- or - The underlying stream does not support reading.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is less than zero.-or-<paramref name="array" />
        /// length minus the index starting point is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">The data is in an invalid format.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override int Read(byte[] array, int offset, int count) { return default(int); }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// This operation is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <param name="offset">The location in the stream.</param>
        /// <param name="origin">One of the <see cref="SeekOrigin" /> values.</param>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
        /// <summary>
        /// This operation is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <param name="value">The length of the stream.</param>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override void SetLength(long value) { }
        /// <summary>
        /// Writes compressed bytes to the underlying stream from the specified byte array.
        /// </summary>
        /// <param name="array">The buffer that contains the data to compress.</param>
        /// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
        /// <param name="count">The maximum number of bytes to write.</param>
        public override void Write(byte[] array, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    }
    /// <summary>
    /// Provides methods and properties used to compress and decompress streams.
    /// </summary>
    public partial class GZipStream : System.IO.Stream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GZipStream" /> class
        /// by using the specified stream and compression level.
        /// </summary>
        /// <param name="stream">The stream to write the compressed data to.</param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression efficiency
        /// when compressing the stream.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The stream does not support write operations such as compression. (The
        /// <see cref="Stream.CanWrite" /> property on the stream object is false.)
        /// </exception>
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GZipStream" /> class
        /// by using the specified stream and compression level, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream to write the compressed data to.</param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression efficiency
        /// when compressing the stream.
        /// </param>
        /// <param name="leaveOpen">
        /// true to leave the stream object open after disposing the <see cref="GZipStream" />
        /// object; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The stream does not support write operations such as compression. (The
        /// <see cref="Stream.CanWrite" /> property on the stream object is false.)
        /// </exception>
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GZipStream" /> class
        /// by using the specified stream and compression mode.
        /// </summary>
        /// <param name="stream">The stream the compressed or decompressed data is written to.</param>
        /// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="mode" /> is not a valid <see cref="CompressionMode" />
        /// enumeration value.-or-<see cref="CompressionMode" /> is
        /// <see cref="CompressionMode.Compress" />  and <see cref="Stream.CanWrite" /> is false.-or-
        /// <see cref="CompressionMode" /> is <see cref="CompressionMode.Decompress" />  and
        /// <see cref="Stream.CanRead" /> is false.
        /// </exception>
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GZipStream" /> class
        /// by using the specified stream and compression mode, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream the compressed or decompressed data is written to.</param>
        /// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after disposing the <see cref="GZipStream" />
        /// object; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="mode" /> is not a valid <see cref="CompressionMode" />
        /// value.-or-<see cref="CompressionMode" /> is
        /// <see cref="CompressionMode.Compress" />  and <see cref="Stream.CanWrite" /> is false.-or-
        /// <see cref="CompressionMode" /> is <see cref="CompressionMode.Decompress" />  and
        /// <see cref="Stream.CanRead" /> is false.
        /// </exception>
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
        /// <summary>
        /// Gets a reference to the underlying stream.
        /// </summary>
        /// <returns>
        /// A stream object that represents the underlying stream.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The underlying stream is closed.</exception>
        public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports reading while decompressing a file.
        /// </summary>
        /// <returns>
        /// true if the <see cref="CompressionMode" /> value is Decompress, and
        /// the underlying stream supports reading and is not closed; otherwise, false.
        /// </returns>
        public override bool CanRead { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports seeking.
        /// </summary>
        /// <returns>
        /// false in all cases.
        /// </returns>
        public override bool CanSeek { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the stream supports writing.
        /// </summary>
        /// <returns>
        /// true if the <see cref="CompressionMode" /> value is Compress, and
        /// the underlying stream supports writing and is not closed; otherwise, false.
        /// </returns>
        public override bool CanWrite { get { return default(bool); } }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Length { get { return default(long); } }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Position { get { return default(long); } set { } }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="GZipStream" />
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// The current implementation of this method has no functionality.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override void Flush() { }
        /// <summary>
        /// Reads a number of decompressed bytes into the specified byte array.
        /// </summary>
        /// <param name="array">The array used to store decompressed bytes.</param>
        /// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
        /// <param name="count">The maximum number of decompressed bytes to read.</param>
        /// <returns>
        /// The number of bytes that were decompressed into the byte array. If the end of the stream has
        /// been reached, zero or the number of bytes read is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="CompressionMode" /> value was Compress when the object
        /// was created.- or -The underlying stream does not support reading.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is less than zero.-or-<paramref name="array" />
        /// length minus the index starting point is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">The data is in an invalid format.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override int Read(byte[] array, int offset, int count) { return default(int); }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <param name="offset">The location in the stream.</param>
        /// <param name="origin">One of the <see cref="SeekOrigin" /> values.</param>
        /// <returns>
        /// A long value.
        /// </returns>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
        /// <summary>
        /// This property is not supported and always throws a <see cref="NotSupportedException" />.
        /// </summary>
        /// <param name="value">The length of the stream.</param>
        /// <exception cref="NotSupportedException">This property is not supported on this stream.</exception>
        public override void SetLength(long value) { }
        /// <summary>
        /// Writes compressed bytes to the underlying stream from the specified byte array.
        /// </summary>
        /// <param name="array">The buffer that contains the data to compress.</param>
        /// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <exception cref="ObjectDisposedException">
        /// The write operation cannot be performed because the stream is closed.
        /// </exception>
        public override void Write(byte[] array, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    }
    /// <summary>
    /// Represents a package of compressed files in the zip archive format.
    /// </summary>
    public partial class ZipArchive : System.IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipArchive" /> class
        /// from the specified stream.
        /// </summary>
        /// <param name="stream">The stream that contains the archive to be read.</param>
        /// <exception cref="ArgumentException">The stream is already closed or does not support reading.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="IO.InvalidDataException">
        /// The contents of the stream are not in the zip archive format.
        /// </exception>
        public ZipArchive(System.IO.Stream stream) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipArchive" /> class
        /// from the specified stream and with the specified mode.
        /// </summary>
        /// <param name="stream">The input or output stream.</param>
        /// <param name="mode">
        /// One of the enumeration values that indicates whether the zip archive is used to read, create,
        /// or update entries.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The stream is already closed, or the capabilities of the stream do not match the mode.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="mode" /> is an invalid value.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The contents of the stream could not be interpreted as a zip archive.-or-<paramref name="mode" />
        /// is <see cref="ZipArchiveMode.Update" /> and an entry is missing
        /// from the archive or is corrupt and cannot be read.-or-<paramref name="mode" /> is
        /// <see cref="ZipArchiveMode.Update" /> and an entry is too large to fit into memory.
        /// </exception>
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipArchive" /> class
        /// on the specified stream for the specified mode, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The input or output stream.</param>
        /// <param name="mode">
        /// One of the enumeration values that indicates whether the zip archive is used to read, create,
        /// or update entries.
        /// </param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="ZipArchive" />
        /// object is disposed; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The stream is already closed, or the capabilities of the stream do not match the mode.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="mode" /> is an invalid value.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The contents of the stream could not be interpreted as a zip archive.-or-<paramref name="mode" />
        /// is <see cref="ZipArchiveMode.Update" /> and an entry is missing
        /// from the archive or is corrupt and cannot be read.-or-<paramref name="mode" /> is
        /// <see cref="ZipArchiveMode.Update" /> and an entry is too large to fit into memory.
        /// </exception>
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipArchive" /> class
        /// on the specified stream for the specified mode, uses the specified encoding for entry names,
        /// and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The input or output stream.</param>
        /// <param name="mode">
        /// One of the enumeration values that indicates whether the zip archive is used to read, create,
        /// or update entries.
        /// </param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="ZipArchive" />
        /// object is disposed; otherwise, false.
        /// </param>
        /// <param name="entryNameEncoding">
        /// The encoding to use when reading or writing entry names in this archive. Specify a value for
        /// this parameter only when an encoding is required for interoperability with zip archive tools and libraries
        /// that do not support UTF-8 encoding for entry names.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The stream is already closed, or the capabilities of the stream do not match the mode.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="mode" /> is an invalid value.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The contents of the stream could not be interpreted as a zip archive.-or-<paramref name="mode" />
        /// is <see cref="ZipArchiveMode.Update" /> and an entry is missing
        /// from the archive or is corrupt and cannot be read.-or-<paramref name="mode" /> is
        /// <see cref="ZipArchiveMode.Update" /> and an entry is too large to fit into memory.
        /// </exception>
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) { }
        /// <summary>
        /// Gets the collection of entries that are currently in the zip archive.
        /// </summary>
        /// <returns>
        /// The collection of entries that are currently in the zip archive.
        /// </returns>
        /// <exception cref="NotSupportedException">The zip archive does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        /// <exception cref="IO.InvalidDataException">
        /// The zip archive is corrupt, and its entries cannot be retrieved.
        /// </exception>
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry>); } }
        /// <summary>
        /// Gets a value that describes the type of action the zip archive can perform on entries.
        /// </summary>
        /// <returns>
        /// One of the enumeration values that describes the type of action (read, create, or update) the
        /// zip archive can perform on entries.
        /// </returns>
        public System.IO.Compression.ZipArchiveMode Mode { get { return default(System.IO.Compression.ZipArchiveMode); } }
        /// <summary>
        /// Creates an empty entry that has the specified path and entry name in the zip archive.
        /// </summary>
        /// <param name="entryName">
        /// A path, relative to the root of the archive, that specifies the name of the entry to be created.
        /// </param>
        /// <returns>
        /// An empty entry in the zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="entryName" /> is <see cref="String.Empty" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="entryName" /> is null.</exception>
        /// <exception cref="NotSupportedException">The zip archive does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
        /// <summary>
        /// Creates an empty entry that has the specified entry name and compression level in the zip archive.
        /// </summary>
        /// <param name="entryName">
        /// A path, relative to the root of the archive, that specifies the name of the entry to be created.
        /// </param>
        /// <param name="compressionLevel">
        /// One of the enumeration values that indicates whether to emphasize speed or compression effectiveness
        /// when creating the entry.
        /// </param>
        /// <returns>
        /// An empty entry in the zip archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="entryName" /> is <see cref="String.Empty" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="entryName" /> is null.</exception>
        /// <exception cref="NotSupportedException">The zip archive does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
        /// <summary>
        /// Releases the resources used by the current instance of the <see cref="ZipArchive" />
        /// class.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Called by the <see cref="ZipArchive.Dispose" /> and
        /// <see cref="Object.Finalize" /> methods to release the unmanaged resources used by the current instance of the
        /// <see cref="ZipArchive" /> class, and optionally finishes writing the archive and releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to finish writing the archive and release unmanaged and managed resources; false to release
        /// only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// Retrieves a wrapper for the specified entry in the zip archive.
        /// </summary>
        /// <param name="entryName">A path, relative to the root of the archive, that identifies the entry to retrieve.</param>
        /// <returns>
        /// A wrapper for the specified entry in the archive; null if the entry does not exist in the archive.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="entryName" /> is <see cref="String.Empty" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="entryName" /> is null.</exception>
        /// <exception cref="NotSupportedException">The zip archive does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The zip archive has been disposed.</exception>
        /// <exception cref="IO.InvalidDataException">
        /// The zip archive is corrupt, and its entries cannot be retrieved.
        /// </exception>
        public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    }
    /// <summary>
    /// Represents a compressed file within a zip archive.
    /// </summary>
    public partial class ZipArchiveEntry
    {
        internal ZipArchiveEntry() { }
        /// <summary>
        /// Gets the zip archive that the entry belongs to.
        /// </summary>
        /// <returns>
        /// The zip archive that the entry belongs to, or null if the entry has been deleted.
        /// </returns>
        public System.IO.Compression.ZipArchive Archive { get { return default(System.IO.Compression.ZipArchive); } }
        /// <summary>
        /// Gets the compressed size of the entry in the zip archive.
        /// </summary>
        /// <returns>
        /// The compressed size of the entry in the zip archive.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The value of the property is not available because the entry has been modified.
        /// </exception>
        public long CompressedLength { get { return default(long); } }
        /// <summary>
        /// Gets the relative path of the entry in the zip archive.
        /// </summary>
        /// <returns>
        /// The relative path of the entry in the zip archive.
        /// </returns>
        public string FullName { get { return default(string); } }
        /// <summary>
        /// Gets or sets the last time the entry in the zip archive was changed.
        /// </summary>
        /// <returns>
        /// The last time the entry in the zip archive was changed.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The attempt to set this property failed, because the zip archive for the entry is in
        /// <see cref="ZipArchiveMode.Read" /> mode.
        /// </exception>
        /// <exception cref="IOException">
        /// The archive mode is set to <see cref="ZipArchiveMode.Create" />.-
        /// or -The archive mode is set to <see cref="ZipArchiveMode.Update" />
        /// and the entry has been opened.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// An attempt was made to set this property to a value that is either earlier than 1980 January
        /// 1 0:00:00 (midnight) or later than 2107 December 31 23:59:58 (one second before midnight).
        /// </exception>
        public System.DateTimeOffset LastWriteTime { get { return default(System.DateTimeOffset); } set { } }
        /// <summary>
        /// Gets the uncompressed size of the entry in the zip archive.
        /// </summary>
        /// <returns>
        /// The uncompressed size of the entry in the zip archive.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The value of the property is not available because the entry has been modified.
        /// </exception>
        public long Length { get { return default(long); } }
        /// <summary>
        /// Gets the file name of the entry in the zip archive.
        /// </summary>
        /// <returns>
        /// The file name of the entry in the zip archive.
        /// </returns>
        public string Name { get { return default(string); } }
        /// <summary>
        /// Deletes the entry from the zip archive.
        /// </summary>
        /// <exception cref="IOException">The entry is already open for reading or writing.</exception>
        /// <exception cref="NotSupportedException">
        /// The zip archive for this entry was opened in a mode other than
        /// <see cref="ZipArchiveMode.Update" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The zip archive for this entry has been disposed.</exception>
        public void Delete() { }
        /// <summary>
        /// Opens the entry from the zip archive.
        /// </summary>
        /// <returns>
        /// The stream that represents the contents of the entry.
        /// </returns>
        /// <exception cref="IOException">
        /// The entry is already currently open for writing.-or-The entry has been deleted from the archive.-or-The
        /// archive for this entry was opened with the <see cref="ZipArchiveMode.Create" />
        /// mode, and this entry has already been written to.
        /// </exception>
        /// <exception cref="IO.InvalidDataException">
        /// The entry is either missing from the archive or is corrupt and cannot be read. -or-The entry
        /// has been compressed by using a compression method that is not supported.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The zip archive for this entry has been disposed.</exception>
        public System.IO.Stream Open() { return default(System.IO.Stream); }
        /// <summary>
        /// Retrieves the relative path of the entry in the zip archive.
        /// </summary>
        /// <returns>
        /// The relative path of the entry, which is the value stored in the
        /// <see cref="FullName" /> property.
        /// </returns>
        public override string ToString() { return default(string); }
    }
    /// <summary>
    /// Specifies values for interacting with zip archive entries.
    /// </summary>
    public enum ZipArchiveMode
    {
        /// <summary>
        /// Only creating new archive entries is permitted.
        /// </summary>
        Create = 1,
        /// <summary>
        /// Only reading archive entries is permitted.
        /// </summary>
        Read = 0,
        /// <summary>
        /// Both read and write operations are permitted for archive entries.
        /// </summary>
        Update = 2,
    }
}
