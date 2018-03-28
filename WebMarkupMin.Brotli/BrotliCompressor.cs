using BrotliSharpLib;
using System.IO;
using System.IO.Compression;

namespace WebMarkupMin.AspNet.Common.Compressors
{
    public class BrotliCompressor : ICompressor
    {
        public string EncodingToken => "br";

        private CompressionLevel _compressionLevel;

        public BrotliCompressor(CompressionLevel compressionLevel)
        {
            _compressionLevel = compressionLevel;
        }

        public Stream Compress(Stream stream)
        {
            if (_compressionLevel == CompressionLevel.NoCompression) return stream;

            using (var brStream = new BrotliStream(stream, CompressionMode.Compress))
            {
                if (_compressionLevel == CompressionLevel.Fastest) brStream.SetQuality(1);
                return brStream;
            }
        }
    }
}