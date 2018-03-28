# WebMarkupMin.Brotli
Brotli compressor for WebMarkupMin library based on BrotliSharpLib

It is published as nuget package under name [WebMarkupMin.Brotli](https://www.nuget.org/packages/WebMarkupMin.Brotli/).

Here is example of how you can use it in ASP.NET Core MVC projects:

```csharp
public static void ConfigureResponseOptimizations(this IServiceCollection services)
{
    services
        .AddWebMarkupMin()
        .AddHttpCompression(options =>
        {
            options.CompressorFactories = new List<ICompressorFactory>
            {
                new BrotliCompressorFactory(new BrotliCompressionSettings { Level = CompressionLevel.Fastest }),
                new DeflateCompressorFactory(new DeflateCompressionSettings { Level = CompressionLevel.Fastest }),
                new GZipCompressorFactory(new GZipCompressionSettings { Level = CompressionLevel.Fastest }),
            };
        });
}
```

Then you can use it in Startup.cs class like this:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.ConfigureResponseOptimizations();
}
```
