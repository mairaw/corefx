// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.IO
{
    /// <summary>
    /// Reads primitive data types as binary values in a specific encoding.
    /// </summary>
    public partial class BinaryReader : System.IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryReader" /> class based on the
        /// specified stream and using UTF-8 encoding.
        /// </summary>
        /// <param name="input">The input stream.</param>
        /// <exception cref="ArgumentException">
        /// The stream does not support reading, is null, or is already closed.
        /// </exception>
        public BinaryReader(System.IO.Stream input) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryReader" /> class based on the
        /// specified stream and character encoding.
        /// </summary>
        /// <param name="input">The input stream.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="ArgumentException">
        /// The stream does not support reading, is null, or is already closed.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="encoding" /> is null.</exception>
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryReader" /> class based on the
        /// specified stream and character encoding, and optionally leaves the stream open.
        /// </summary>
        /// <param name="input">The input stream.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="BinaryReader" /> object is
        /// disposed; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The stream does not support reading, is null, or is already closed.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="encoding" /> or <paramref name="input" /> is null.
        /// </exception>
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding, bool leaveOpen) { }
        /// <summary>
        /// Exposes access to the underlying stream of the <see cref="BinaryReader" />.
        /// </summary>
        /// <returns>
        /// The underlying stream associated with the BinaryReader.
        /// </returns>
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Releases all resources used by the current instance of the <see cref="BinaryReader" />
        /// class.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="BinaryReader" /> class
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// Fills the internal buffer with the specified number of bytes read from the stream.
        /// </summary>
        /// <param name="numBytes">The number of bytes to be read.</param>
        /// <exception cref="EndOfStreamException">
        /// The end of the stream is reached before <paramref name="numBytes" /> could be read.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Requested <paramref name="numBytes" /> is larger than the internal buffer size.
        /// </exception>
        protected virtual void FillBuffer(int numBytes) { }
        /// <summary>
        /// Returns the next available character and does not advance the byte or character position.
        /// </summary>
        /// <returns>
        /// The next available character, or -1 if no more characters are available or the stream does
        /// not support seeking.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ArgumentException">
        /// The current character cannot be decoded into the internal character buffer by using the
        /// <see cref="Text.Encoding" /> selected for the stream.
        /// </exception>
        public virtual int PeekChar() { return default(int); }
        /// <summary>
        /// Reads characters from the underlying stream and advances the current position of the stream
        /// in accordance with the Encoding used and the specific character being read from the stream.
        /// </summary>
        /// <returns>
        /// The next character from the input stream, or -1 if no characters are currently available.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual int Read() { return default(int); }
        /// <summary>
        /// Reads the specified number of bytes from the stream, starting from a specified point in the
        /// byte array.
        /// </summary>
        /// <returns>
        /// The number of bytes read into <paramref name="buffer" />. This might be less than the number
        /// of bytes requested if that many bytes are not available, or it might be zero if the end of
        /// the stream is reached.
        /// </returns>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="index">The starting point in the buffer at which to begin reading into the buffer.</param>
        /// <param name="count">The number of bytes to read.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// -or-The number of decoded characters to read is greater than <paramref name="count" />. This
        /// can happen if a Unicode decoder returns fallback characters or a surrogate pair.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int Read(byte[] buffer, int index, int count) { return default(int); }
        /// <summary>
        /// Reads the specified number of characters from the stream, starting from a specified point in
        /// the character array.
        /// </summary>
        /// <returns>
        /// The total number of characters read into the buffer. This might be less than the number of
        /// characters requested if that many characters are not currently available, or it might be zero if the
        /// end of the stream is reached.
        /// </returns>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="index">The starting point in the buffer at which to begin reading into the buffer.</param>
        /// <param name="count">The number of characters to read.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// -or-The number of decoded characters to read is greater than <paramref name="count" />. This
        /// can happen if a Unicode decoder returns fallback characters or a surrogate pair.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int Read(char[] buffer, int index, int count) { return default(int); }
        /// <summary>
        /// Reads in a 32-bit integer in compressed format.
        /// </summary>
        /// <returns>
        /// A 32-bit integer in compressed format.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">The stream is corrupted.</exception>
        protected internal int Read7BitEncodedInt() { return default(int); }
        /// <summary>
        /// Reads a Boolean value from the current stream and advances the current position of the stream
        /// by one byte.
        /// </summary>
        /// <returns>
        /// true if the byte is nonzero; otherwise, false.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual bool ReadBoolean() { return default(bool); }
        /// <summary>
        /// Reads the next byte from the current stream and advances the current position of the stream
        /// by one byte.
        /// </summary>
        /// <returns>
        /// The next byte read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual byte ReadByte() { return default(byte); }
        /// <summary>
        /// Reads the specified number of bytes from the current stream into a byte array and advances
        /// the current position by that number of bytes.
        /// </summary>
        /// <returns>
        /// A byte array containing data read from the underlying stream. This might be less than the number
        /// of bytes requested if the end of the stream is reached.
        /// </returns>
        /// <param name="count">
        /// The number of bytes to read. This value must be 0 or a non-negative number or an exception
        /// will occur.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The number of decoded characters to read is greater than <paramref name="count" />. This can
        /// happen if a Unicode decoder returns fallback characters or a surrogate pair.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="count" /> is negative.</exception>
        public virtual byte[] ReadBytes(int count) { return default(byte[]); }
        /// <summary>
        /// Reads the next character from the current stream and advances the current position of the stream
        /// in accordance with the Encoding used and the specific character being read from the stream.
        /// </summary>
        /// <returns>
        /// A character read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ArgumentException">A surrogate character was read.</exception>
        public virtual char ReadChar() { return default(char); }
        /// <summary>
        /// Reads the specified number of characters from the current stream, returns the data in a character
        /// array, and advances the current position in accordance with the Encoding used and the specific
        /// character being read from the stream.
        /// </summary>
        /// <returns>
        /// A character array containing data read from the underlying stream. This might be less than
        /// the number of characters requested if the end of the stream is reached.
        /// </returns>
        /// <param name="count">The number of characters to read.</param>
        /// <exception cref="ArgumentException">
        /// The number of decoded characters to read is greater than <paramref name="count" />. This can
        /// happen if a Unicode decoder returns fallback characters or a surrogate pair.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="count" /> is negative.</exception>
        public virtual char[] ReadChars(int count) { return default(char[]); }
        /// <summary>
        /// Reads a decimal value from the current stream and advances the current position of the stream
        /// by sixteen bytes.
        /// </summary>
        /// <returns>
        /// A decimal value read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual decimal ReadDecimal() { return default(decimal); }
        /// <summary>
        /// Reads an 8-byte floating point value from the current stream and advances the current position
        /// of the stream by eight bytes.
        /// </summary>
        /// <returns>
        /// An 8-byte floating point value read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual double ReadDouble() { return default(double); }
        /// <summary>
        /// Reads a 2-byte signed integer from the current stream and advances the current position of
        /// the stream by two bytes.
        /// </summary>
        /// <returns>
        /// A 2-byte signed integer read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual short ReadInt16() { return default(short); }
        /// <summary>
        /// Reads a 4-byte signed integer from the current stream and advances the current position of
        /// the stream by four bytes.
        /// </summary>
        /// <returns>
        /// A 4-byte signed integer read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int ReadInt32() { return default(int); }
        /// <summary>
        /// Reads an 8-byte signed integer from the current stream and advances the current position of
        /// the stream by eight bytes.
        /// </summary>
        /// <returns>
        /// An 8-byte signed integer read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual long ReadInt64() { return default(long); }
        /// <summary>
        /// Reads a signed byte from this stream and advances the current position of the stream by one
        /// byte.
        /// </summary>
        /// <returns>
        /// A signed byte read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual sbyte ReadSByte() { return default(sbyte); }
        /// <summary>
        /// Reads a 4-byte floating point value from the current stream and advances the current position
        /// of the stream by four bytes.
        /// </summary>
        /// <returns>
        /// A 4-byte floating point value read from the current stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual float ReadSingle() { return default(float); }
        /// <summary>
        /// Reads a string from the current stream. The string is prefixed with the length, encoded as
        /// an integer seven bits at a time.
        /// </summary>
        /// <returns>
        /// The string being read.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual string ReadString() { return default(string); }
        /// <summary>
        /// Reads a 2-byte unsigned integer from the current stream using little-endian encoding and advances
        /// the position of the stream by two bytes.
        /// </summary>
        /// <returns>
        /// A 2-byte unsigned integer read from this stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual ushort ReadUInt16() { return default(ushort); }
        /// <summary>
        /// Reads a 4-byte unsigned integer from the current stream and advances the position of the stream
        /// by four bytes.
        /// </summary>
        /// <returns>
        /// A 4-byte unsigned integer read from this stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual uint ReadUInt32() { return default(uint); }
        /// <summary>
        /// Reads an 8-byte unsigned integer from the current stream and advances the position of the stream
        /// by eight bytes.
        /// </summary>
        /// <returns>
        /// An 8-byte unsigned integer read from this stream.
        /// </returns>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual ulong ReadUInt64() { return default(ulong); }
    }
    /// <summary>
    /// Writes primitive types in binary to a stream and supports writing strings in a specific encoding.
    /// </summary>
    public partial class BinaryWriter : System.IDisposable
    {
        /// <summary>
        /// Specifies a <see cref="BinaryWriter" /> with no backing store.
        /// </summary>
        public static readonly System.IO.BinaryWriter Null;
        /// <summary>
        /// Holds the underlying stream.
        /// </summary>
        protected System.IO.Stream OutStream;
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryWriter" /> class that writes
        /// to a stream.
        /// </summary>
        protected BinaryWriter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryWriter" /> class based on the
        /// specified stream and using UTF-8 encoding.
        /// </summary>
        /// <param name="output">The output stream.</param>
        /// <exception cref="ArgumentException">The stream does not support writing or is already closed.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="output" /> is null.</exception>
        public BinaryWriter(System.IO.Stream output) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryWriter" /> class based on the
        /// specified stream and character encoding.
        /// </summary>
        /// <param name="output">The output stream.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="ArgumentException">The stream does not support writing or is already closed.</exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="output" /> or <paramref name="encoding" /> is null.
        /// </exception>
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryWriter" /> class based on the
        /// specified stream and character encoding, and optionally leaves the stream open.
        /// </summary>
        /// <param name="output">The output stream.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="BinaryWriter" /> object is
        /// disposed; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentException">The stream does not support writing or is already closed.</exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="output" /> or <paramref name="encoding" /> is null.
        /// </exception>
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding, bool leaveOpen) { }
        /// <summary>
        /// Gets the underlying stream of the <see cref="BinaryWriter" />.
        /// </summary>
        /// <returns>
        /// The underlying stream associated with the BinaryWriter.
        /// </returns>
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Releases all resources used by the current instance of the <see cref="BinaryWriter" />
        /// class.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="BinaryWriter" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the
        /// underlying device.
        /// </summary>
        public virtual void Flush() { }
        /// <summary>
        /// Sets the position within the current stream.
        /// </summary>
        /// <returns>
        /// The position with the current stream.
        /// </returns>
        /// <param name="offset">A byte offset relative to <paramref name="origin" />.</param>
        /// <param name="origin">
        /// A field of <see cref="SeekOrigin" /> indicating the reference point from which
        /// the new position is to be obtained.
        /// </param>
        /// <exception cref="IOException">The file pointer was moved to an invalid location.</exception>
        /// <exception cref="ArgumentException">The <see cref="SeekOrigin" /> value is invalid.</exception>
        public virtual long Seek(int offset, System.IO.SeekOrigin origin) { return default(long); }
        /// <summary>
        /// Writes a one-byte Boolean value to the current stream, with 0 representing false and 1 representing
        /// true.
        /// </summary>
        /// <param name="value">The Boolean value to write (0 or 1).</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(bool value) { }
        /// <summary>
        /// Writes an unsigned byte to the current stream and advances the stream position by one byte.
        /// </summary>
        /// <param name="value">The unsigned byte to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(byte value) { }
        /// <summary>
        /// Writes a byte array to the underlying stream.
        /// </summary>
        /// <param name="buffer">A byte array containing the data to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        public virtual void Write(byte[] buffer) { }
        /// <summary>
        /// Writes a region of a byte array to the current stream.
        /// </summary>
        /// <param name="buffer">A byte array containing the data to write.</param>
        /// <param name="index">The starting point in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">The number of bytes to write.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(byte[] buffer, int index, int count) { }
        /// <summary>
        /// Writes a Unicode character to the current stream and advances the current position of the stream
        /// in accordance with the Encoding used and the specific characters being written to the stream.
        /// </summary>
        /// <param name="ch">The non-surrogate, Unicode character to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="ch" /> is a single surrogate character.
        /// </exception>
        public virtual void Write(char ch) { }
        /// <summary>
        /// Writes a character array to the current stream and advances the current position of the stream
        /// in accordance with the Encoding used and the specific characters being written to the stream.
        /// </summary>
        /// <param name="chars">A character array containing the data to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="chars" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(char[] chars) { }
        /// <summary>
        /// Writes a section of a character array to the current stream, and advances the current position
        /// of the stream in accordance with the Encoding used and perhaps the specific characters being written
        /// to the stream.
        /// </summary>
        /// <param name="chars">A character array containing the data to write.</param>
        /// <param name="index">The starting point in <paramref name="chars" /> from which to begin writing.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="chars" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(char[] chars, int index, int count) { }
        /// <summary>
        /// Writes a decimal value to the current stream and advances the stream position by sixteen bytes.
        /// </summary>
        /// <param name="value">The decimal value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(decimal value) { }
        /// <summary>
        /// Writes an eight-byte floating-point value to the current stream and advances the stream position
        /// by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte floating-point value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(double value) { }
        /// <summary>
        /// Writes a two-byte signed integer to the current stream and advances the stream position by
        /// two bytes.
        /// </summary>
        /// <param name="value">The two-byte signed integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(short value) { }
        /// <summary>
        /// Writes a four-byte signed integer to the current stream and advances the stream position by
        /// four bytes.
        /// </summary>
        /// <param name="value">The four-byte signed integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(int value) { }
        /// <summary>
        /// Writes an eight-byte signed integer to the current stream and advances the stream position
        /// by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte signed integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(long value) { }
        /// <summary>
        /// Writes a signed byte to the current stream and advances the stream position by one byte.
        /// </summary>
        /// <param name="value">The signed byte to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(sbyte value) { }
        /// <summary>
        /// Writes a four-byte floating-point value to the current stream and advances the stream position
        /// by four bytes.
        /// </summary>
        /// <param name="value">The four-byte floating-point value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(float value) { }
        /// <summary>
        /// Writes a length-prefixed string to this stream in the current encoding of the
        /// <see cref="BinaryWriter" />, and advances the current position of the stream in accordance with the encoding used and
        /// the specific characters being written to the stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public virtual void Write(string value) { }
        /// <summary>
        /// Writes a two-byte unsigned integer to the current stream and advances the stream position by
        /// two bytes.
        /// </summary>
        /// <param name="value">The two-byte unsigned integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ushort value) { }
        /// <summary>
        /// Writes a four-byte unsigned integer to the current stream and advances the stream position
        /// by four bytes.
        /// </summary>
        /// <param name="value">The four-byte unsigned integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        /// <summary>
        /// Writes an eight-byte unsigned integer to the current stream and advances the stream position
        /// by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte unsigned integer to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        /// <summary>
        /// Writes a 32-bit integer in a compressed format.
        /// </summary>
        /// <param name="value">The 32-bit integer to be written.</param>
        /// <exception cref="EndOfStreamException">The end of the stream is reached.</exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        /// <exception cref="IOException">The stream is closed.</exception>
        protected void Write7BitEncodedInt(int value) { }
    }
    /// <summary>
    /// Adds a buffering layer to read and write operations on another stream. This class cannot be
    /// inherited.
    /// </summary>
    public sealed partial class BufferedStream : System.IO.Stream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BufferedStream" /> class with a default
        /// buffer size of 4096 bytes.
        /// </summary>
        /// <param name="stream">The current stream.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public BufferedStream(Stream stream) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BufferedStream" /> class with the
        /// specified buffer size.
        /// </summary>
        /// <param name="stream">The current stream.</param>
        /// <param name="bufferSize">The buffer size in bytes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bufferSize" /> is negative.
        /// </exception>
        public BufferedStream(Stream stream, int bufferSize) { }
        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        /// <returns>
        /// true if the stream supports reading; false if the stream is closed or was opened with write-only
        /// access.
        /// </returns>
        public override bool CanRead { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        /// <returns>
        /// true if the stream supports seeking; false if the stream is closed or if the stream was constructed
        /// from an operating system handle such as a pipe or output to the console.
        /// </returns>
        public override bool CanSeek { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        /// <returns>
        /// true if the stream supports writing; false if the stream is closed or was opened with read-only
        /// access.
        /// </returns>
        public override bool CanWrite { get { return default(bool); } }
        /// <summary>
        /// Gets the stream length in bytes.
        /// </summary>
        /// <returns>
        /// The stream length in bytes.
        /// </returns>
        /// <exception cref="IOException">The underlying stream is null or closed.</exception>
        /// <exception cref="NotSupportedException">The stream does not support seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override long Length { get { return default(long); } }
        /// <summary>
        /// Gets the position within the current stream.
        /// </summary>
        /// <returns>
        /// The position within the current stream.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value passed to <see cref="Seek(Int64,SeekOrigin)" />
        /// is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs, such as the stream being closed.</exception>
        /// <exception cref="NotSupportedException">The stream does not support seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override long Position { get { return default(long); } set { } }
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Clears all buffers for this stream and causes any buffered data to be written to the underlying
        /// device.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="IOException">The data source or repository is not open.</exception>
        public override void Flush() { }
        /// <summary>
        /// Asynchronously clears all buffers for this stream, causes any buffered data to be written to
        /// the underlying device, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Copies bytes from the current buffered stream to an array.
        /// </summary>
        /// <returns>
        /// The total number of bytes read into <paramref name="array" />. This can be less than the number
        /// of bytes requested if that many bytes are not currently available, or 0 if the end of the
        /// stream has been reached before any data can be read.
        /// </returns>
        /// <param name="array">The buffer to which bytes are to be copied.</param>
        /// <param name="offset">The byte offset in the buffer at which to begin reading bytes.</param>
        /// <param name="count">The number of bytes to be read.</param>
        /// <exception cref="ArgumentException">
        /// Length of <paramref name="array" /> minus <paramref name="offset" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">The stream is not open or is null.</exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override int Read(byte[] array, int offset, int count) { return default(int); }
        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream, advances the position within
        /// the stream by the number of bytes read, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">The buffer to write the data into.</param>
        /// <param name="offset">
        /// The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a byte from the underlying stream and returns the byte cast to an int, or returns -1
        /// if reading from the end of the stream.
        /// </summary>
        /// <returns>
        /// The byte cast to an int, or -1 if reading from the end of the stream.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs, such as the stream being closed.</exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override int ReadByte() { return default(int); }
        /// <summary>
        /// Sets the position within the current buffered stream.
        /// </summary>
        /// <returns>
        /// The new position within the current buffered stream.
        /// </returns>
        /// <param name="offset">A byte offset relative to <paramref name="origin" />.</param>
        /// <param name="origin">
        /// A value of type <see cref="SeekOrigin" /> indicating the reference point from
        /// which to obtain the new position.
        /// </param>
        /// <exception cref="IOException">The stream is not open or is null.</exception>
        /// <exception cref="NotSupportedException">The stream does not support seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override long Seek(long offset, SeekOrigin origin) { return default(long); }
        /// <summary>
        /// Sets the length of the buffered stream.
        /// </summary>
        /// <param name="value">An integer indicating the desired length of the current buffered stream in bytes.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value" /> is negative.</exception>
        /// <exception cref="IOException">The stream is not open or is null.</exception>
        /// <exception cref="NotSupportedException">The stream does not support both writing and seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override void SetLength(long value) { }
        /// <summary>
        /// Copies bytes to the buffered stream and advances the current position within the buffered stream
        /// by the number of bytes written.
        /// </summary>
        /// <param name="array">
        /// The byte array from which to copy <paramref name="count" /> bytes to the current buffered
        /// stream.
        /// </param>
        /// <param name="offset">
        /// The offset in the buffer at which to begin copying bytes to the current buffered stream.
        /// </param>
        /// <param name="count">The number of bytes to be written to the current buffered stream.</param>
        /// <exception cref="ArgumentException">
        /// Length of <paramref name="array" /> minus <paramref name="offset" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">The stream is closed or null.</exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override void Write(byte[] array, int offset, int count) { }
        /// <summary>
        /// Asynchronously writes a sequence of bytes to the current stream, advances the current position
        /// within this stream by the number of bytes written, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The buffer to write data from.</param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes
        /// to the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a byte to the current position in the buffered stream.
        /// </summary>
        /// <param name="value">A byte to write to the stream.</param>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override void WriteByte(byte value) { }
    }
    /// <summary>
    /// The exception that is thrown when reading is attempted past the end of a stream.
    /// </summary>
    public partial class EndOfStreamException : System.IO.IOException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfStreamException" /> class with
        /// its message string set to a system-supplied message and its HRESULT set to COR_E_ENDOFSTREAM.
        /// </summary>
        public EndOfStreamException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfStreamException" /> class with
        /// its message string set to <paramref name="message" /> and its HRESULT set to COR_E_ENDOFSTREAM.
        /// </summary>
        /// <param name="message">
        /// A string that describes the error. The content of <paramref name="message" /> is intended
        /// to be understood by humans. The caller of this constructor is required to ensure that this
        /// string has been localized for the current system culture.
        /// </param>
        public EndOfStreamException(string message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfStreamException" /> class with
        /// a specified error message and a reference to the inner exception that is the cause of this
        /// exception.
        /// </summary>
        /// <param name="message">
        /// A string that describes the error. The content of <paramref name="message" /> is intended
        /// to be understood by humans. The caller of this constructor is required to ensure that this
        /// string has been localized for the current system culture.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception. If the <paramref name="innerException" />
        /// parameter is not null, the current exception is raised in a catch block that handles the
        /// inner exception.
        /// </param>
        public EndOfStreamException(string message, System.Exception innerException) { }
    }
    /// <summary>
    /// The exception that is thrown when a data stream is in an invalid format.
    /// </summary>
    public sealed partial class InvalidDataException : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataException" /> class.
        /// </summary>
        public InvalidDataException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataException" /> class with
        /// a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidDataException(string message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataException" /> class with
        /// a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception. If the <paramref name="innerException" />
        /// parameter is not null, the current exception is raised in a catch block that handles the
        /// inner exception.
        /// </param>
        public InvalidDataException(string message, System.Exception innerException) { }
    }
    /// <summary>
    /// Creates a stream whose backing store is memory.To browse the .NET Framework source code for
    /// this type, see the Reference Source.
    /// </summary>
    public partial class MemoryStream : System.IO.Stream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryStream" /> class with an expandable
        /// capacity initialized to zero.
        /// </summary>
        public MemoryStream() { }
        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="MemoryStream" /> class
        /// based on the specified byte array.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create the current stream.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        public MemoryStream(byte[] buffer) { }
        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="MemoryStream" /> class
        /// based on the specified byte array with the <see cref="CanWrite" />
        /// property set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream.</param>
        /// <param name="writable">
        /// The setting of the <see cref="CanWrite" /> property, which determines
        /// whether the stream supports writing.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        public MemoryStream(byte[] buffer, bool writable) { }
        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="MemoryStream" /> class
        /// based on the specified region (index) of a byte array.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream.</param>
        /// <param name="index">The index into <paramref name="buffer" /> at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        public MemoryStream(byte[] buffer, int index, int count) { }
        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="MemoryStream" /> class
        /// based on the specified region of a byte array, with the <see cref="CanWrite" />
        /// property set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream.</param>
        /// <param name="index">The index in <paramref name="buffer" /> at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes.</param>
        /// <param name="writable">
        /// The setting of the <see cref="CanWrite" /> property, which determines
        /// whether the stream supports writing.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> are negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        public MemoryStream(byte[] buffer, int index, int count, bool writable) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryStream" /> class based on the
        /// specified region of a byte array, with the <see cref="CanWrite" />
        /// property set as specified, and the ability to call <see cref="MemoryStream.GetBuffer" />
        /// set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream.</param>
        /// <param name="index">The index into <paramref name="buffer" /> at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes.</param>
        /// <param name="writable">
        /// The setting of the <see cref="CanWrite" /> property, which determines
        /// whether the stream supports writing.
        /// </param>
        /// <param name="publiclyVisible">
        /// true to enable <see cref="MemoryStream.GetBuffer" />, which returns the unsigned
        /// byte array from which the stream was created; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryStream" /> class with an expandable
        /// capacity initialized as specified.
        /// </summary>
        /// <param name="capacity">The initial size of the internal array in bytes.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity" /> is negative.</exception>
        public MemoryStream(int capacity) { }
        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        /// <returns>
        /// true if the stream is open.
        /// </returns>
        public override bool CanRead { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        /// <returns>
        /// true if the stream is open.
        /// </returns>
        public override bool CanSeek { get { return default(bool); } }
        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        /// <returns>
        /// true if the stream supports writing; otherwise, false.
        /// </returns>
        public override bool CanWrite { get { return default(bool); } }
        /// <summary>
        /// Gets or sets the number of bytes allocated for this stream.
        /// </summary>
        /// <returns>
        /// The length of the usable portion of the buffer for the stream.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// A capacity is set that is negative or less than the current length of the stream.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current stream is closed.</exception>
        /// <exception cref="NotSupportedException">
        /// set is invoked on a stream whose capacity cannot be modified.
        /// </exception>
        public virtual int Capacity { get { return default(int); } set { } }
        /// <summary>
        /// Gets the length of the stream in bytes.
        /// </summary>
        /// <returns>
        /// The length of the stream in bytes.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override long Length { get { return default(long); } }
        /// <summary>
        /// Gets or sets the current position within the stream.
        /// </summary>
        /// <returns>
        /// The current position within the stream.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The position is set to a negative value or a value greater than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream is closed.</exception>
        public override long Position { get { return default(long); } set { } }
        /// <summary>
        /// Asynchronously reads all the bytes from the current stream and writes them to another stream,
        /// using a specified buffer size and cancellation token.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous copy operation.
        /// </returns>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="buffersize" /> is negative or zero.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or the destination stream is disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading, or the destination stream does not support writing.
        /// </exception>
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="MemoryStream" /> class
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Overrides the <see cref="Stream.Flush" /> method so that no action is performed.
        /// </summary>
        public override void Flush() { }
        /// <summary>
        /// Asynchronously clears all buffers for this stream, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Reads a block of bytes from the current stream and writes the data to a buffer.
        /// </summary>
        /// <returns>
        /// The total number of bytes written into the buffer. This can be less than the number of bytes
        /// requested if that number of bytes are not currently available, or zero if the end of the stream is
        /// reached before any bytes are read.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified byte array with the values between <paramref name="offset" />
        /// and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced
        /// by the characters read from the current stream.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> at which to begin storing data from
        /// the current stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current stream instance is closed.</exception>
        public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); return default(int); }
        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream, advances the position within
        /// the stream by the number of bytes read, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">The buffer to write the data into.</param>
        /// <param name="offset">
        /// The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a byte from the current stream.
        /// </summary>
        /// <returns>
        /// The byte cast to a <see cref="Int32" />, or -1 if the end of the stream has been
        /// reached.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The current stream instance is closed.</exception>
        public override int ReadByte() { return default(int); }
        /// <summary>
        /// Sets the position within the current stream to the specified value.
        /// </summary>
        /// <returns>
        /// The new position within the stream, calculated by combining the initial reference point and
        /// the offset.
        /// </returns>
        /// <param name="offset">
        /// The new position within the stream. This is relative to the <paramref name="loc" /> parameter,
        /// and can be positive or negative.
        /// </param>
        /// <param name="loc">
        /// A value of type <see cref="SeekOrigin" />, which acts as the seek reference point.
        /// </param>
        /// <exception cref="IOException">Seeking is attempted before the beginning of the stream.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> is greater than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// There is an invalid <see cref="SeekOrigin" />. -or-<paramref name="offset" />
        /// caused an arithmetic overflow.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current stream instance is closed.</exception>
        public override long Seek(long offset, System.IO.SeekOrigin loc) { return default(long); }
        /// <summary>
        /// Sets the length of the current stream to the specified value.
        /// </summary>
        /// <param name="value">The value at which to set the length.</param>
        /// <exception cref="NotSupportedException">
        /// The current stream is not resizable and <paramref name="value" /> is larger than the current
        /// capacity.-or- The current stream does not support writing.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="value" /> is negative or is greater than the maximum length of the
        /// <see cref="MemoryStream" />, where the maximum length is(<see cref="Int32.MaxValue" /> - origin), and origin
        /// is the index into the underlying buffer at which the stream starts.
        /// </exception>
        public override void SetLength(long value) { }
        /// <summary>
        /// Writes the stream contents to a byte array, regardless of the <see cref="Position" />
        /// property.
        /// </summary>
        /// <returns>
        /// A new byte array.
        /// </returns>
        public virtual byte[] ToArray() { return default(byte[]); }
        /// <summary>
        /// Returns the array of unsigned bytes from which this stream was created. The return value indicates
        /// whether the conversion succeeded.
        /// </summary>
        /// <returns>
        /// true if the conversion was successful; otherwise, false.
        /// </returns>
        /// <param name="buffer">The byte array segment from which this stream was created.</param>
        public virtual bool TryGetBuffer(out System.ArraySegment<byte> buffer) { buffer = default(System.ArraySegment<byte>); return default(bool); }
        /// <summary>
        /// Writes a block of bytes to the current stream using data read from a buffer.
        /// </summary>
        /// <param name="buffer">The buffer to write data from.</param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to
        /// the current stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="NotSupportedException">
        /// The stream does not support writing. For additional information see <see cref="Stream.CanWrite" />.
        /// -or- The current position is closer than <paramref name="count" /> bytes to the end of
        /// the stream, and the capacity cannot be modified.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> are negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The current stream instance is closed.</exception>
        public override void Write(byte[] buffer, int offset, int count) { }
        /// <summary>
        /// Asynchronously writes a sequence of bytes to the current stream, advances the current position
        /// within this stream by the number of bytes written, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The buffer to write data from.</param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes
        /// to the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a byte to the current stream at the current position.
        /// </summary>
        /// <param name="value">The byte to write.</param>
        /// <exception cref="NotSupportedException">
        /// The stream does not support writing. For additional information see <see cref="Stream.CanWrite" />.
        /// -or- The current position is at the end of the stream, and the capacity cannot be modified.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current stream is closed.</exception>
        public override void WriteByte(byte value) { }
        /// <summary>
        /// Writes the entire contents of this memory stream to another stream.
        /// </summary>
        /// <param name="stream">The stream to write this memory stream to.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The current or target stream is closed.</exception>
        public virtual void WriteTo(System.IO.Stream stream) { }
    }
    /// <summary>
    /// Specifies the position in a stream to use for seeking.
    /// </summary>
    public enum SeekOrigin
    {
        /// <summary>
        /// Specifies the beginning of a stream.
        /// </summary>
        Begin = 0,
        /// <summary>
        /// Specifies the current position within a stream.
        /// </summary>
        Current = 1,
        /// <summary>
        /// Specifies the end of a stream.
        /// </summary>
        End = 2,
    }
    /// <summary>
    /// Provides a generic view of a sequence of bytes. This is an abstract class.To browse the .NET
    /// Framework source code for this type, see the Reference Source.
    /// </summary>
    public abstract partial class Stream : System.IDisposable
    {
        /// <summary>
        /// A Stream with no backing store.
        /// </summary>
        public static readonly System.IO.Stream Null;
        /// <summary>
        /// Initializes a new instance of the <see cref="Stream" /> class.
        /// </summary>
        protected Stream() { }
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether the current stream supports
        /// reading.
        /// </summary>
        /// <returns>
        /// true if the stream supports reading; otherwise, false.
        /// </returns>
        public abstract bool CanRead { get; }
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether the current stream supports
        /// seeking.
        /// </summary>
        /// <returns>
        /// true if the stream supports seeking; otherwise, false.
        /// </returns>
        public abstract bool CanSeek { get; }
        /// <summary>
        /// Gets a value that determines whether the current stream can time out.
        /// </summary>
        /// <returns>
        /// A value that determines whether the current stream can time out.
        /// </returns>
        public virtual bool CanTimeout { get { return default(bool); } }
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether the current stream supports
        /// writing.
        /// </summary>
        /// <returns>
        /// true if the stream supports writing; otherwise, false.
        /// </returns>
        public abstract bool CanWrite { get; }
        /// <summary>
        /// When overridden in a derived class, gets the length in bytes of the stream.
        /// </summary>
        /// <returns>
        /// A long value representing the length of the stream in bytes.
        /// </returns>
        /// <exception cref="NotSupportedException">A class derived from Stream does not support seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public abstract long Length { get; }
        /// <summary>
        /// When overridden in a derived class, gets or sets the position within the current stream.
        /// </summary>
        /// <returns>
        /// The current position within the stream.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="NotSupportedException">The stream does not support seeking.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public abstract long Position { get; set; }
        /// <summary>
        /// Gets or sets a value, in miliseconds, that determines how long the stream will attempt to read
        /// before timing out.
        /// </summary>
        /// <returns>
        /// A value, in miliseconds, that determines how long the stream will attempt to read before timing
        /// out.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="ReadTimeout" /> method always throws an
        /// <see cref="InvalidOperationException" />.
        /// </exception>
        public virtual int ReadTimeout { get { return default(int); } set { } }
        /// <summary>
        /// Gets or sets a value, in miliseconds, that determines how long the stream will attempt to write
        /// before timing out.
        /// </summary>
        /// <returns>
        /// A value, in miliseconds, that determines how long the stream will attempt to write before timing
        /// out.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="WriteTimeout" /> method always throws an
        /// <see cref="InvalidOperationException" />.
        /// </exception>
        public virtual int WriteTimeout { get { return default(int); } set { } }
        /// <summary>
        /// Reads the bytes from the current stream and writes them to another stream.
        /// </summary>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading.-or-<paramref name="destination" /> does not support
        /// writing.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or <paramref name="destination" /> were closed before the
        /// <see cref="CopyTo(Stream)" /> method was called.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        public void CopyTo(System.IO.Stream destination) { }
        /// <summary>
        /// Reads the bytes from the current stream and writes them to another stream, using a specified
        /// buffer size.
        /// </summary>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <param name="bufferSize">
        /// The size of the buffer. This value must be greater than zero. The default size is 81920.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bufferSize" /> is negative or zero.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading.-or-<paramref name="destination" /> does not support
        /// writing.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or <paramref name="destination" /> were closed before the
        /// <see cref="CopyTo(Stream)" /> method was called.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        public void CopyTo(System.IO.Stream destination, int bufferSize) { }
        /// <summary>
        /// Asynchronously reads the bytes from the current stream and writes them to another stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous copy operation.
        /// </returns>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or the destination stream is disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading, or the destination stream does not support writing.
        /// </exception>
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Asynchronously reads the bytes from the current stream and writes them to another stream, using
        /// a specified buffer size.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous copy operation.
        /// </returns>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <param name="bufferSize">
        /// The size, in bytes, of the buffer. This value must be greater than zero. The default size is
        /// 81920.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="buffersize" /> is negative or zero.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or the destination stream is disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading, or the destination stream does not support writing.
        /// </exception>
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Asynchronously reads the bytes from the current stream and writes them to another stream, using
        /// a specified buffer size and cancellation token.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous copy operation.
        /// </returns>
        /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
        /// <param name="bufferSize">
        /// The size, in bytes, of the buffer. This value must be greater than zero. The default size is
        /// 81920.
        /// </param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="destination" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="buffersize" /> is negative or zero.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// Either the current stream or the destination stream is disposed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The current stream does not support reading, or the destination stream does not support writing.
        /// </exception>
        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Releases all resources used by the <see cref="Stream" />.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="Stream" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// When overridden in a derived class, clears all buffers for this stream and causes any buffered
        /// data to be written to the underlying device.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public abstract void Flush();
        /// <summary>
        /// Asynchronously clears all buffers for this stream and causes any buffered data to be written
        /// to the underlying device.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Asynchronously clears all buffers for this stream, causes any buffered data to be written to
        /// the underlying device, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// When overridden in a derived class, reads a sequence of bytes from the current stream and advances
        /// the position within the stream by the number of bytes read.
        /// </summary>
        /// <returns>
        /// The total number of bytes read into the buffer. This can be less than the number of bytes requested
        /// if that many bytes are not currently available, or zero (0) if the end of the stream has been
        /// reached.
        /// </returns>
        /// <param name="buffer">
        /// An array of bytes. When this method returns, the buffer contains the specified byte array
        /// with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" />
        /// - 1) replaced by the bytes read from the current source.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data
        /// read from the current stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public abstract int Read(byte[] buffer, int offset, int count);
        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream and advances the position
        /// within the stream by the number of bytes read.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">The buffer to write the data into.</param>
        /// <param name="offset">
        /// The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous read operation.
        /// </exception>
        public System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream, advances the position within
        /// the stream by the number of bytes read, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">The buffer to write the data into.</param>
        /// <param name="offset">
        /// The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous read operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a byte from the stream and advances the position within the stream by one byte, or returns
        /// -1 if at the end of the stream.
        /// </summary>
        /// <returns>
        /// The unsigned byte cast to an Int32, or -1 if at the end of the stream.
        /// </returns>
        /// <exception cref="NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public virtual int ReadByte() { return default(int); }
        /// <summary>
        /// When overridden in a derived class, sets the position within the current stream.
        /// </summary>
        /// <returns>
        /// The new position within the current stream.
        /// </returns>
        /// <param name="offset">A byte offset relative to the <paramref name="origin" /> parameter.</param>
        /// <param name="origin">
        /// A value of type <see cref="SeekOrigin" /> indicating the reference point used
        /// to obtain the new position.
        /// </param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="NotSupportedException">
        /// The stream does not support seeking, such as if the stream is constructed from a pipe or console
        /// output.
        /// </exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public abstract long Seek(long offset, System.IO.SeekOrigin origin);
        /// <summary>
        /// When overridden in a derived class, sets the length of the current stream.
        /// </summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="NotSupportedException">
        /// The stream does not support both writing and seeking, such as if the stream is constructed
        /// from a pipe or console output.
        /// </exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public abstract void SetLength(long value);
        /// <summary>
        /// When overridden in a derived class, writes a sequence of bytes to the current stream and advances
        /// the current position within this stream by the number of bytes written.
        /// </summary>
        /// <param name="buffer">
        /// An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" />
        /// to the current stream.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to
        /// the current stream.
        /// </param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is greater than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" />  is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">
        /// An I/O error occured, such as the specified file cannot be found.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">
        /// <see cref="Write(Byte[],Int32,Int32)" /> was called
        /// after the stream was closed.
        /// </exception>
        public abstract void Write(byte[] buffer, int offset, int count);
        /// <summary>
        /// Asynchronously writes a sequence of bytes to the current stream and advances the current position
        /// within this stream by the number of bytes written.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The buffer to write data from.</param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes
        /// to the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous write operation.
        /// </exception>
        public System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Asynchronously writes a sequence of bytes to the current stream, advances the current position
        /// within this stream by the number of bytes written, and monitors cancellation requests.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The buffer to write data from.</param>
        /// <param name="offset">
        /// The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes
        /// to the stream.
        /// </param>
        /// <param name="count">The maximum number of bytes to write.</param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// <see cref="Threading.CancellationToken.None" />.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a byte to the current position in the stream and advances the position within the stream
        /// by one byte.
        /// </summary>
        /// <param name="value">The byte to write to the stream.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="NotSupportedException">
        /// The stream does not support writing, or the stream is already closed.
        /// </exception>
        /// <exception cref="ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public virtual void WriteByte(byte value) { }
    }
    /// <summary>
    /// Implements a <see cref="TextReader" /> that reads characters from a byte stream
    /// in a particular encoding.To browse the .NET Framework source code for this type, see the Reference
    /// Source.
    /// </summary>
    public partial class StreamReader : System.IO.TextReader
    {
        /// <summary>
        /// A <see cref="StreamReader" /> object around an empty stream.
        /// </summary>
        public static readonly new System.IO.StreamReader Null;
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="stream" /> does not support reading.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public StreamReader(System.IO.Stream stream) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream, with the specified byte order mark detection option.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <param name="detectEncodingFromByteOrderMarks">
        /// Indicates whether to look for byte order marks at the beginning of the file.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="stream" /> does not support reading.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public StreamReader(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream, with the specified character encoding.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="stream" /> does not support reading.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream, with the specified character encoding and byte order mark detection option.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="detectEncodingFromByteOrderMarks">
        /// Indicates whether to look for byte order marks at the beginning of the file.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="stream" /> does not support reading.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream, with the specified character encoding, byte order mark detection option, and buffer
        /// size.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="detectEncodingFromByteOrderMarks">
        /// Indicates whether to look for byte order marks at the beginning of the file.
        /// </param>
        /// <param name="bufferSize">The minimum buffer size.</param>
        /// <exception cref="ArgumentException">The stream does not support reading.</exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bufferSize" /> is less than or equal to zero.
        /// </exception>
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamReader" /> class for the specified
        /// stream based on the specified character encoding, byte order mark detection option, and buffer
        /// size, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream to read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="detectEncodingFromByteOrderMarks">
        /// true to look for byte order marks at the beginning of the file; otherwise, false.
        /// </param>
        /// <param name="bufferSize">The minimum buffer size.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="StreamReader" /> object is
        /// disposed; otherwise, false.
        /// </param>
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }
        /// <summary>
        /// Returns the underlying stream.
        /// </summary>
        /// <returns>
        /// The underlying stream.
        /// </returns>
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Gets the current character encoding that the current <see cref="StreamReader" />
        /// object is using.
        /// </summary>
        /// <returns>
        /// The current character encoding used by the current reader. The value can be different after
        /// the first call to any <see cref="Overload:System.IO.StreamReader.Read" /> method of
        /// <see cref="StreamReader" />, since encoding autodetection is not done until the first call to a
        /// <see cref="Overload:System.IO.StreamReader.Read" /> method.
        /// </returns>
        public virtual System.Text.Encoding CurrentEncoding { get { return default(System.Text.Encoding); } }
        /// <summary>
        /// Gets a value that indicates whether the current stream position is at the end of the stream.
        /// </summary>
        /// <returns>
        /// true if the current stream position is at the end of the stream; otherwise false.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The underlying stream has been disposed.</exception>
        public bool EndOfStream { get { return default(bool); } }
        /// <summary>
        /// Clears the internal buffer.
        /// </summary>
        public void DiscardBufferedData() { }
        /// <summary>
        /// Closes the underlying stream, releases the unmanaged resources used by the
        /// <see cref="StreamReader" />, and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Returns the next available character but does not consume it.
        /// </summary>
        /// <returns>
        /// An integer representing the next character to be read, or -1 if there are no characters to
        /// be read or if the stream does not support seeking.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public override int Peek() { return default(int); }
        /// <summary>
        /// Reads the next character from the input stream and advances the character position by one character.
        /// </summary>
        /// <returns>
        /// The next character from the input stream represented as an <see cref="Int32" /> object,
        /// or -1 if no more characters are available.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public override int Read() { return default(int); }
        /// <summary>
        /// Reads a specified maximum of characters from the current stream into a buffer, beginning at
        /// the specified index.
        /// </summary>
        /// <returns>
        /// The number of characters that have been read, or 0 if at the end of the stream and no data
        /// was read. The number will be less than or equal to the <paramref name="count" /> parameter,
        /// depending on whether the data is available within the stream.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index + count - 1" />) replaced by the characters read
        /// from the current source.
        /// </param>
        /// <param name="index">The index of <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs, such as the stream is closed.</exception>
        public override int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current stream asynchronously and writes
        /// the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the stream is reached before the specified
        /// number of characters is written into the buffer, the current method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current stream and writes the data
        /// to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// The number of characters that have been read. The number will be less than or equal to
        /// <paramref name="count" />, depending on whether all input characters have been read.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index + count - 1" />) replaced by the characters read
        /// from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// The <see cref="StreamReader" /> is closed.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        public override int ReadBlock(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current stream asynchronously and writes
        /// the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the stream has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the stream is reached before the specified
        /// number of characters is written into the buffer, the method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a line of characters from the current stream and returns the data as a string.
        /// </summary>
        /// <returns>
        /// The next line from the input stream, or null if the end of the input stream is reached.
        /// </returns>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public override string ReadLine() { return default(string); }
        /// <summary>
        /// Reads a line of characters asynchronously from the current stream and returns the data as a
        /// string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the next line from the stream, or is null if all the characters have
        /// been read.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        /// <summary>
        /// Reads all characters from the current position to the end of the stream.
        /// </summary>
        /// <returns>
        /// The rest of the stream as a string, from the current position to the end. If the current position
        /// is at the end of the stream, returns an empty string ("").
        /// </returns>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public override string ReadToEnd() { return default(string); }
        /// <summary>
        /// Reads all characters from the current position to the end of the stream asynchronously and
        /// returns them as one string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains a string with the characters from the current position to the end of
        /// the stream.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    /// <summary>
    /// Implements a <see cref="TextWriter" /> for writing characters to a stream in a
    /// particular encoding.To browse the .NET Framework source code for this type, see the Reference
    /// Source.
    /// </summary>
    public partial class StreamWriter : System.IO.TextWriter
    {
        /// <summary>
        /// Provides a StreamWriter with no backing store that can be written to, but not read from.
        /// </summary>
        public static readonly new System.IO.StreamWriter Null;
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamWriter" /> class for the specified
        /// stream by using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <exception cref="ArgumentException"><paramref name="stream" /> is not writable.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public StreamWriter(System.IO.Stream stream) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamWriter" /> class for the specified
        /// stream by using the specified encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException"><paramref name="stream" /> is not writable.</exception>
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamWriter" /> class for the specified
        /// stream by using the specified encoding and buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">The buffer size, in bytes.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bufferSize" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException"><paramref name="stream" /> is not writable.</exception>
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamWriter" /> class for the specified
        /// stream by using the specified encoding and buffer size, and optionally leaves the stream open.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">The buffer size, in bytes.</param>
        /// <param name="leaveOpen">
        /// true to leave the stream open after the <see cref="StreamWriter" /> object is
        /// disposed; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stream" /> or <paramref name="encoding" /> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bufferSize" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException"><paramref name="stream" /> is not writable.</exception>
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize, bool leaveOpen) { }
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="StreamWriter" /> will flush
        /// its buffer to the underlying stream after every call to <see cref="Write(Char)" />.
        /// </summary>
        /// <returns>
        /// true to force <see cref="StreamWriter" /> to flush its buffer; otherwise, false.
        /// </returns>
        public virtual bool AutoFlush { get { return default(bool); } set { } }
        /// <summary>
        /// Gets the underlying stream that interfaces with a backing store.
        /// </summary>
        /// <returns>
        /// The stream this StreamWriter is writing to.
        /// </returns>
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        /// <summary>
        /// Gets the <see cref="Text.Encoding" /> in which the output is written.
        /// </summary>
        /// <returns>
        /// The <see cref="Text.Encoding" /> specified in the constructor for the current instance,
        /// or <see cref="Text.UTF8Encoding" /> if an encoding was not specified.
        /// </returns>
        public override System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="StreamWriter" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        /// <exception cref="Text.EncoderFallbackException">
        /// The current encoding does not support displaying half of a Unicode surrogate pair.
        /// </exception>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the
        /// underlying stream.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The current writer is closed.</exception>
        /// <exception cref="IOException">An I/O error has occurred.</exception>
        /// <exception cref="Text.EncoderFallbackException">
        /// The current encoding does not support displaying half of a Unicode surrogate pair.
        /// </exception>
        public override void Flush() { }
        /// <summary>
        /// Clears all buffers for this stream asynchronously and causes any buffered data to be written
        /// to the underlying device.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public override System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a character to the stream.
        /// </summary>
        /// <param name="value">The character to write to the stream.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and current writer is closed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and the contents of the buffer cannot be written to the underlying fixed
        /// size stream because the <see cref="StreamWriter" /> is at the end the stream.
        /// </exception>
        public override void Write(char value) { }
        /// <summary>
        /// Writes a character array to the stream.
        /// </summary>
        /// <param name="buffer">
        /// A character array containing the data to write. If <paramref name="buffer" /> is null, nothing
        /// is written.
        /// </param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and current writer is closed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and the contents of the buffer cannot be written to the underlying fixed
        /// size stream because the <see cref="StreamWriter" /> is at the end the stream.
        /// </exception>
        public override void Write(char[] buffer) { }
        /// <summary>
        /// Writes a subarray of characters to the stream.
        /// </summary>
        /// <param name="buffer">A character array that contains the data to write.</param>
        /// <param name="index">The character position in the buffer at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and current writer is closed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and the contents of the buffer cannot be written to the underlying fixed
        /// size stream because the <see cref="StreamWriter" /> is at the end the stream.
        /// </exception>
        public override void Write(char[] buffer, int index, int count) { }
        /// <summary>
        /// Writes a string to the stream.
        /// </summary>
        /// <param name="value">
        /// The string to write to the stream. If <paramref name="value" /> is null, nothing is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and current writer is closed.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <see cref="AutoFlush" /> is true or the <see cref="StreamWriter" />
        /// buffer is full, and the contents of the buffer cannot be written to the underlying fixed
        /// size stream because the <see cref="StreamWriter" /> is at the end the stream.
        /// </exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public override void Write(string value) { }
        /// <summary>
        /// Writes a character to the stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the stream.</param>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters to the stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">A character array that contains the data to write.</param>
        /// <param name="index">The character position in the buffer at which to begin reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string to the stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">
        /// The string to write to the stream. If <paramref name="value" /> is null, nothing is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a line terminator asynchronously to the stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a character followed by a line terminator asynchronously to the stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the stream.</param>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters followed by a line terminator asynchronously to the stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string followed by a line terminator asynchronously to the stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The string to write. If the value is null, only a line terminator is written.</param>
        /// <exception cref="ObjectDisposedException">The stream writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stream writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
    /// <summary>
    /// Implements a <see cref="TextReader" /> that reads from a string.
    /// </summary>
    public partial class StringReader : System.IO.TextReader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringReader" /> class that reads
        /// from the specified string.
        /// </summary>
        /// <param name="s">The string to which the <see cref="StringReader" /> should be initialized.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
        public StringReader(string s) { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="StringReader" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Returns the next available character but does not consume it.
        /// </summary>
        /// <returns>
        /// An integer representing the next character to be read, or -1 if no more characters are available
        /// or the stream does not support seeking.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The current reader is closed.</exception>
        public override int Peek() { return default(int); }
        /// <summary>
        /// Reads the next character from the input string and advances the character position by one character.
        /// </summary>
        /// <returns>
        /// The next character from the underlying string, or -1 if no more characters are available.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The current reader is closed.</exception>
        public override int Read() { return default(int); }
        /// <summary>
        /// Reads a block of characters from the input string and advances the character position by
        /// <paramref name="count" />.
        /// </summary>
        /// <returns>
        /// The total number of characters read into the buffer. This can be less than the number of characters
        /// requested if that many characters are not currently available, or zero if the end of the underlying
        /// string has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The starting index in the buffer.</param>
        /// <param name="count">The number of characters to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current reader is closed.</exception>
        public override int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current string asynchronously and writes
        /// the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the string has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the string is reached before the specified
        /// number of characters is written into the buffer, the method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current string asynchronously and writes
        /// the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the string has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the string is reached before the specified
        /// number of characters is written into the buffer, the method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a line of characters from the current string and returns the data as a string.
        /// </summary>
        /// <returns>
        /// The next line from the current string, or null if the end of the string is reached.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The current reader is closed.</exception>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        public override string ReadLine() { return default(string); }
        /// <summary>
        /// Reads a line of characters asynchronously from the current string and returns the data as a
        /// string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the next line from the string reader, or is null if all the characters
        /// have been read.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        /// <summary>
        /// Reads all characters from the current position to the end of the string and returns them as
        /// a single string.
        /// </summary>
        /// <returns>
        /// The content from the current position to the end of the underlying string.
        /// </returns>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The current reader is closed.</exception>
        public override string ReadToEnd() { return default(string); }
        /// <summary>
        /// Reads all characters from the current position to the end of the string asynchronously and
        /// returns them as a single string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains a string with the characters from the current position to the end of
        /// the string.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    /// <summary>
    /// Implements a <see cref="TextWriter" /> for writing information to a string. The
    /// information is stored in an underlying <see cref="Text.StringBuilder" />.
    /// </summary>
    public partial class StringWriter : System.IO.TextWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriter" /> class.
        /// </summary>
        public StringWriter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriter" /> class with the specified
        /// format control.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> object that controls formatting.</param>
        public StringWriter(System.IFormatProvider formatProvider) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriter" /> class that writes
        /// to the specified <see cref="Text.StringBuilder" />.
        /// </summary>
        /// <param name="sb">The <see cref="Text.StringBuilder" /> object to write to.</param>
        /// <exception cref="ArgumentNullException"><paramref name="sb" /> is null.</exception>
        public StringWriter(System.Text.StringBuilder sb) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriter" /> class that writes
        /// to the specified <see cref="Text.StringBuilder" /> and has the specified format provider.
        /// </summary>
        /// <param name="sb">The <see cref="Text.StringBuilder" /> object to write to.</param>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> object that controls formatting.</param>
        /// <exception cref="ArgumentNullException"><paramref name="sb" /> is null.</exception>
        public StringWriter(System.Text.StringBuilder sb, System.IFormatProvider formatProvider) { }
        /// <summary>
        /// Gets the <see cref="Text.Encoding" /> in which the output is written.
        /// </summary>
        /// <returns>
        /// The Encoding in which the output is written.
        /// </returns>
        public override System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="StringWriter" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing) { }
        /// <summary>
        /// Asynchronously clears all buffers for the current writer and causes any buffered data to be
        /// written to the underlying device.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        public override System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Returns the underlying <see cref="Text.StringBuilder" />.
        /// </summary>
        /// <returns>
        /// The underlying StringBuilder.
        /// </returns>
        public virtual System.Text.StringBuilder GetStringBuilder() { return default(System.Text.StringBuilder); }
        /// <summary>
        /// Returns a string containing the characters written to the current StringWriter so far.
        /// </summary>
        /// <returns>
        /// The string containing the characters written to the current StringWriter.
        /// </returns>
        public override string ToString() { return default(string); }
        /// <summary>
        /// Writes a character to the string.
        /// </summary>
        /// <param name="value">The character to write.</param>
        /// <exception cref="ObjectDisposedException">The writer is closed.</exception>
        public override void Write(char value) { }
        /// <summary>
        /// Writes a subarray of characters to the string.
        /// </summary>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The position in the buffer at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// (<paramref name="index" /> + <paramref name="count" />)&gt; <paramref name="buffer" />. Length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The writer is closed.</exception>
        public override void Write(char[] buffer, int index, int count) { }
        /// <summary>
        /// Writes a string to the current string.
        /// </summary>
        /// <param name="value">The string to write.</param>
        /// <exception cref="ObjectDisposedException">The writer is closed.</exception>
        public override void Write(string value) { }
        /// <summary>
        /// Writes a character to the string asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the string.</param>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters to the string asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The position in the buffer at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string to the current string asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">
        /// The string to write. If <paramref name="value" /> is null, nothing is written to the text
        /// stream.
        /// </param>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a character followed by a line terminator asynchronously to the string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the string.</param>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters followed by a line terminator asynchronously to the string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The position in the buffer at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string followed by a line terminator asynchronously to the current string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The string to write. If the value is null, only a line terminator is written.</param>
        /// <exception cref="ObjectDisposedException">The string writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The string writer is currently in use by a previous write operation.
        /// </exception>
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
    /// <summary>
    /// Represents a reader that can read a sequential series of characters.
    /// </summary>
    public abstract partial class TextReader : System.IDisposable
    {
        /// <summary>
        /// Provides a TextReader with no data to read from.
        /// </summary>
        public static readonly System.IO.TextReader Null;
        /// <summary>
        /// Initializes a new instance of the <see cref="TextReader" /> class.
        /// </summary>
        protected TextReader() { }
        /// <summary>
        /// Releases all resources used by the <see cref="TextReader" /> object.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="TextReader" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// Reads the next character without changing the state of the reader or the character source.
        /// Returns the next available character without actually reading it from the reader.
        /// </summary>
        /// <returns>
        /// An integer representing the next character to be read, or -1 if no more characters are available
        /// or the reader does not support seeking.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int Peek() { return default(int); }
        /// <summary>
        /// Reads the next character from the text reader and advances the character position by one character.
        /// </summary>
        /// <returns>
        /// The next character from the text reader, or -1 if no more characters are available. The default
        /// implementation returns -1.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int Read() { return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current reader and writes the data
        /// to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// The number of characters that have been read. The number will be less than or equal to
        /// <paramref name="count" />, depending on whether the data is available within the reader. This method
        /// returns 0 (zero) if it is called when no more characters are left to read.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the reader is reached before the specified
        /// number of characters is read into the buffer, the method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current text reader asynchronously
        /// and writes the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the text has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the text is reached before the specified
        /// number of characters is read into the buffer, the current method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current text reader and writes the
        /// data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// The number of characters that have been read. The number will be less than or equal to
        /// <paramref name="count" />, depending on whether all input characters have been read.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, this parameter contains the specified character array with the values
        /// between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" />
        /// -1) replaced by the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual int ReadBlock(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        /// <summary>
        /// Reads a specified maximum number of characters from the current text reader asynchronously
        /// and writes the data to a buffer, beginning at the specified index.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the total number of bytes read into the buffer. The result value can
        /// be less than the number of bytes requested if the number of bytes currently available is less
        /// than the requested number, or it can be 0 (zero) if the end of the text has been reached.
        /// </returns>
        /// <param name="buffer">
        /// When this method returns, contains the specified character array with the values between
        /// <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by
        /// the characters read from the current source.
        /// </param>
        /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
        /// <param name="count">
        /// The maximum number of characters to read. If the end of the text is reached before the specified
        /// number of characters is read into the buffer, the current method returns.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer
        /// length.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        /// <summary>
        /// Reads a line of characters from the text reader and returns the data as a string.
        /// </summary>
        /// <returns>
        /// The next line from the reader, or null if all characters have been read.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line is larger than <see cref="Int32.MaxValue" />
        /// </exception>
        public virtual string ReadLine() { return default(string); }
        /// <summary>
        /// Reads a line of characters asynchronously and returns the data as a string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains the next line from the text reader, or is null if all of the characters
        /// have been read.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        /// <summary>
        /// Reads all characters from the current position to the end of the text reader and returns them
        /// as one string.
        /// </summary>
        /// <returns>
        /// A string that contains all characters from the current position to the end of the text reader.
        /// </returns>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextReader" /> is closed.</exception>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line is larger than <see cref="Int32.MaxValue" />
        /// </exception>
        public virtual string ReadToEnd() { return default(string); }
        /// <summary>
        /// Reads all characters from the current position to the end of the text reader asynchronously
        /// and returns them as one string.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the <paramref name="TResult" />
        /// parameter contains a string with the characters from the current position to the end of
        /// the text reader.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters is larger than <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text reader has been disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The reader is currently in use by a previous read operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    /// <summary>
    /// Represents a writer that can write a sequential series of characters. This class is abstract.
    /// </summary>
    public abstract partial class TextWriter : System.IDisposable
    {
        /// <summary>
        /// Stores the newline characters used for this TextWriter.
        /// </summary>
        protected char[] CoreNewLine;
        /// <summary>
        /// Provides a TextWriter with no backing store that can be written to, but not read from.
        /// </summary>
        public static readonly System.IO.TextWriter Null;
        /// <summary>
        /// Initializes a new instance of the <see cref="TextWriter" /> class.
        /// </summary>
        protected TextWriter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextWriter" /> class with the specified
        /// format provider.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> object that controls formatting.</param>
        protected TextWriter(System.IFormatProvider formatProvider) { }
        /// <summary>
        /// When overridden in a derived class, returns the character encoding in which the output is written.
        /// </summary>
        /// <returns>
        /// The character encoding in which the output is written.
        /// </returns>
        public abstract System.Text.Encoding Encoding { get; }
        /// <summary>
        /// Gets an object that controls formatting.
        /// </summary>
        /// <returns>
        /// An <see cref="IFormatProvider" /> object for a specific culture, or the formatting
        /// of the current culture if no other culture is specified.
        /// </returns>
        public virtual System.IFormatProvider FormatProvider { get { return default(System.IFormatProvider); } }
        /// <summary>
        /// Gets or sets the line terminator string used by the current TextWriter.
        /// </summary>
        /// <returns>
        /// The line terminator string for the current TextWriter.
        /// </returns>
        public virtual string NewLine { get { return default(string); } set { } }
        /// <summary>
        /// Releases all resources used by the <see cref="TextWriter" /> object.
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="TextWriter" /> and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing) { }
        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the
        /// underlying device.
        /// </summary>
        public virtual void Flush() { }
        /// <summary>
        /// Asynchronously clears all buffers for the current writer and causes any buffered data to be
        /// written to the underlying device.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous flush operation.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes the text representation of a Boolean value to the text string or stream.
        /// </summary>
        /// <param name="value">The Boolean value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(bool value) { }
        /// <summary>
        /// Writes a character to the text string or stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public abstract void Write(char value);
        /// <summary>
        /// Writes a character array to the text string or stream.
        /// </summary>
        /// <param name="buffer">The character array to write to the text stream.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(char[] buffer) { }
        /// <summary>
        /// Writes a subarray of characters to the text string or stream.
        /// </summary>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start retrieving data.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="buffer" /> parameter is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(char[] buffer, int index, int count) { }
        /// <summary>
        /// Writes the text representation of a decimal value to the text string or stream.
        /// </summary>
        /// <param name="value">The decimal value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(decimal value) { }
        /// <summary>
        /// Writes the text representation of an 8-byte floating-point value to the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte floating-point value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(double value) { }
        /// <summary>
        /// Writes the text representation of a 4-byte signed integer to the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte signed integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(int value) { }
        /// <summary>
        /// Writes the text representation of an 8-byte signed integer to the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte signed integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(long value) { }
        /// <summary>
        /// Writes the text representation of an object to the text string or stream by calling the ToString
        /// method on that object.
        /// </summary>
        /// <param name="value">The object to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(object value) { }
        /// <summary>
        /// Writes the text representation of a 4-byte floating-point value to the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte floating-point value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(float value) { }
        /// <summary>
        /// Writes a string to the text string or stream.
        /// </summary>
        /// <param name="value">The string to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void Write(string value) { }
        /// <summary>
        /// Writes a formatted string to the text string or stream, using the same semantics as the
        /// <see cref="String.Format(String,Object)" /> method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is one).
        /// </exception>
        public virtual void Write(string format, object arg0) { }
        /// <summary>
        /// Writes a formatted string to the text string or stream, using the same semantics as the
        /// <see cref="String.Format(String,Object,Object)" /> method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The first object to format and write.</param>
        /// <param name="arg1">The second object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero) or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is two).
        /// </exception>
        public virtual void Write(string format, object arg0, object arg1) { }
        /// <summary>
        /// Writes a formatted string to the text string or stream, using the same semantics as the
        /// <see cref="String.Format(String,Object,Object,Object)" />
        /// method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The first object to format and write.</param>
        /// <param name="arg1">The second object to format and write.</param>
        /// <param name="arg2">The third object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is three).
        /// </exception>
        public virtual void Write(string format, object arg0, object arg1, object arg2) { }
        /// <summary>
        /// Writes a formatted string to the text string or stream, using the same semantics as the
        /// <see cref="String.Format(String,Object[])" /> method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg">An object array that contains zero or more objects to format and write.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="format" /> or <paramref name="arg" /> is null.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the length of the <paramref name="arg" />
        /// array.
        /// </exception>
        public virtual void Write(string format, params object[] arg) { }
        /// <summary>
        /// Writes the text representation of a 4-byte unsigned integer to the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        /// <summary>
        /// Writes the text representation of an 8-byte unsigned integer to the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        /// <summary>
        /// Writes a character to the text string or stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the text stream.</param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a character array to the text string or stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">
        /// The character array to write to the text stream. If <paramref name="buffer" /> is null, nothing
        /// is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public System.Threading.Tasks.Task WriteAsync(char[] buffer) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters to the text string or stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start retrieving data.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string to the text string or stream asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">
        /// The string to write. If <paramref name="value" /> is null, nothing is written to the text
        /// stream.
        /// </param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a line terminator to the text string or stream.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine() { }
        /// <summary>
        /// Writes the text representation of a Boolean value followed by a line terminator to the text
        /// string or stream.
        /// </summary>
        /// <param name="value">The Boolean value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(bool value) { }
        /// <summary>
        /// Writes a character followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(char value) { }
        /// <summary>
        /// Writes an array of characters followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="buffer">The character array from which data is read.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(char[] buffer) { }
        /// <summary>
        /// Writes a subarray of characters followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="buffer">The character array from which data is read.</param>
        /// <param name="index">The character position in <paramref name="buffer" /> at which to start reading data.</param>
        /// <param name="count">The maximum number of characters to write.</param>
        /// <exception cref="ArgumentException">
        /// The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.
        /// </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="buffer" /> parameter is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(char[] buffer, int index, int count) { }
        /// <summary>
        /// Writes the text representation of a decimal value followed by a line terminator to the text
        /// string or stream.
        /// </summary>
        /// <param name="value">The decimal value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(decimal value) { }
        /// <summary>
        /// Writes the text representation of a 8-byte floating-point value followed by a line terminator
        /// to the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte floating-point value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(double value) { }
        /// <summary>
        /// Writes the text representation of a 4-byte signed integer followed by a line terminator to
        /// the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte signed integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(int value) { }
        /// <summary>
        /// Writes the text representation of an 8-byte signed integer followed by a line terminator to
        /// the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte signed integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(long value) { }
        /// <summary>
        /// Writes the text representation of an object by calling the ToString method on that object,
        /// followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="value">
        /// The object to write. If <paramref name="value" /> is null, only the line terminator is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(object value) { }
        /// <summary>
        /// Writes the text representation of a 4-byte floating-point value followed by a line terminator
        /// to the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte floating-point value to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(float value) { }
        /// <summary>
        /// Writes a string followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="value">
        /// The string to write. If <paramref name="value" /> is null, only the line terminator is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        public virtual void WriteLine(string value) { }
        /// <summary>
        /// Writes a formatted string and a new line to the text string or stream, using the same semantics
        /// as the <see cref="String.Format(String,Object)" /> method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is one).
        /// </exception>
        public virtual void WriteLine(string format, object arg0) { }
        /// <summary>
        /// Writes a formatted string and a new line to the text string or stream, using the same semantics
        /// as the <see cref="String.Format(String,Object,Object)" /> method.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The first object to format and write.</param>
        /// <param name="arg1">The second object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is two).
        /// </exception>
        public virtual void WriteLine(string format, object arg0, object arg1) { }
        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as
        /// <see cref="String.Format(String,Object)" />.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg0">The first object to format and write.</param>
        /// <param name="arg1">The second object to format and write.</param>
        /// <param name="arg2">The third object to format and write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the number of objects to be formatted
        /// (which, for this method overload, is three).
        /// </exception>
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }
        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as
        /// <see cref="String.Format(String,Object)" />.
        /// </summary>
        /// <param name="format">A composite format string (see Remarks).</param>
        /// <param name="arg">An object array that contains zero or more objects to format and write.</param>
        /// <exception cref="ArgumentNullException">A string or object is passed in as null.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is not a valid composite format string.-or- The index of a format
        /// item is less than 0 (zero), or greater than or equal to the length of the <paramref name="arg" />
        /// array.
        /// </exception>
        public virtual void WriteLine(string format, params object[] arg) { }
        /// <summary>
        /// Writes the text representation of a 4-byte unsigned integer followed by a line terminator to
        /// the text string or stream.
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(uint value) { }
        /// <summary>
        /// Writes the text representation of an 8-byte unsigned integer followed by a line terminator
        /// to the text string or stream.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer to write.</param>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(ulong value) { }
        /// <summary>
        /// Writes a line terminator asynchronously to the text string or stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteLineAsync() { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a character followed by a line terminator asynchronously to the text string or stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The character to write to the text stream.</param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes an array of characters followed by a line terminator asynchronously to the text string
        /// or stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">
        /// The character array to write to the text stream. If the character array is null, only the line
        /// terminator is written.
        /// </param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public System.Threading.Tasks.Task WriteLineAsync(char[] buffer) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a subarray of characters followed by a line terminator asynchronously to the text string
        /// or stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start retrieving data.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null.</exception>
        /// <exception cref="ArgumentException">
        /// The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> or <paramref name="count" /> is negative.
        /// </exception>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        /// <summary>
        /// Writes a string followed by a line terminator asynchronously to the text string or stream.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous write operation.
        /// </returns>
        /// <param name="value">The string to write. If the value is null, only a line terminator is written.</param>
        /// <exception cref="ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="InvalidOperationException">
        /// The text writer is currently in use by a previous write operation.
        /// </exception>
        public virtual System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
}
