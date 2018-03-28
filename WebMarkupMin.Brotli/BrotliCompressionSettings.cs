using System.IO.Compression;

namespace WebMarkupMin.AspNet.Common.Compressors
{
    public sealed class BrotliCompressionSettings
    {
        public CompressionLevel Level { get; set; } = CompressionLevel.Fastest;
    }
}
