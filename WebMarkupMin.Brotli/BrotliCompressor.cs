using BrotliSharpLib;
using System.IO;
using System.IO.Compression;

namespace WebMarkupMin.AspNet.Common.Compressors
{
    public class BrotliCompressor : ICompressor
    {
        public string EncodingToken { get; } = "br";

        private readonly CompressionLevel _compressionLevel;

        public BrotliCompressor(CompressionLevel compressionLevel)
        {
            _compressionLevel = compressionLevel;
        }

        public Stream Compress(Stream stream)
        {
            if (_compressionLevel == CompressionLevel.NoCompression) return stream;

            var brStream = new BrotliStream(stream, CompressionMode.Compress);
            brStream.SetQuality(1);
            return brStream;
        }
    }
}