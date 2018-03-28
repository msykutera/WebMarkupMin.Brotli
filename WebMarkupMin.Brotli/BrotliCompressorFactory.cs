using System.IO.Compression;

namespace WebMarkupMin.AspNet.Common.Compressors
{
    public class BrotliCompressorFactory : ICompressorFactory
    {
        public string EncodingToken => "br";
        public CompressionLevel CompressionLevel { get; set; } = CompressionLevel.Optimal;

        public ICompressor CreateCompressor() => new BrotliCompressor(CompressionLevel);
    }
}
