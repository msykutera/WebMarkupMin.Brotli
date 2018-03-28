using System.IO.Compression;

namespace WebMarkupMin.AspNet.Common.Compressors
{
    public class BrotliCompressorFactory : ICompressorFactory
    {
        public string EncodingToken { get; } = "br";

        private CompressionLevel _compressionLevel { get; } = CompressionLevel.Fastest;

        public BrotliCompressorFactory() { }

        public BrotliCompressorFactory(BrotliCompressionSettings settings)
        {
            _compressionLevel = settings.Level;
        }

        public ICompressor CreateCompressor() => new BrotliCompressor(_compressionLevel);
    }
}
