using BindingGenerator;
using CppSharp.Types.Std;
using Microsoft.Extensions.Logging;
using Serilog;

namespace YogaBinding.Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                   .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();
            var loggerFactory = LoggerFactory.Create((builder) => { builder.AddSerilog(Log.Logger); });


            BindingGenerator.Generator.Generate(
                new[] { "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\", "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator" },
                new[] {
                    new LibData() {
                    FuncsHeaderPath = "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\YGConfig.h",
                    RuntimeData = new RuntimeData()
                    {
                        PerPlatformPathes = new Dictionary<Platform, string>()
                        {
                            { Platform.Windows, "runtimes/win-x64/yogacore.dll" },
                            { Platform.Linux, "runtimes/linux-x64/libyogacore.so" },
                            { Platform.Android, "libyogacore.so" },
                        }
                    },
                    LibName="YGConfigApi"
                    },
                    new LibData() {
                    FuncsHeaderPath = "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\YGNode.h",
                    RuntimeData = new RuntimeData()
                    {
                        PerPlatformPathes = new Dictionary<Platform, string>()
                        {
                            { Platform.Windows, "runtimes/win-x64/yogacore.dll" },
                            { Platform.Linux, "runtimes/linux-x64/libyogacore.so" },
                            { Platform.Android, "libyogacore.so" },
                        }
                    },
                    LibName="YGNodeApi"
                    },
                    new LibData() {
                    FuncsHeaderPath = "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\YGNodeLayout.h",
                    RuntimeData = new RuntimeData()
                    {
                        PerPlatformPathes = new Dictionary<Platform, string>()
                        {
                            { Platform.Windows, "runtimes/win-x64/yogacore.dll" },
                            { Platform.Linux, "runtimes/linux-x64/libyogacore.so" },
                            { Platform.Android, "libyogacore.so" },
                        }
                    },
                    LibName="YGNodeLayoutApi"
                    },
                    new LibData() {
                    FuncsHeaderPath = "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\YGNodeStyle.h",
                    RuntimeData = new RuntimeData()
                    {
                        PerPlatformPathes = new Dictionary<Platform, string>()
                        {
                            { Platform.Windows, "runtimes/win-x64/yogacore.dll" },
                            { Platform.Linux, "runtimes/linux-x64/libyogacore.so" },
                            { Platform.Android, "libyogacore.so" },
                        }
                    },
                    LibName="YGStyleApi"
                    },
                    new LibData() {
                    FuncsHeaderPath = "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding.Generator\\yoga\\YGPixelGrid.h",
                    RuntimeData = new RuntimeData()
                    {
                        PerPlatformPathes = new Dictionary<Platform, string>()
                        {
                            { Platform.Windows, "runtimes/win-x64/yogacore.dll" },
                            { Platform.Linux, "runtimes/linux-x64/libyogacore.so" },
                            { Platform.Android, "libyogacore.so" },
                        }
                    },
                    LibName="YGPixelGridApi"
                    }
                },
                "C:\\Users\\Anton\\source\\repos\\YogaBinding\\YogaBinding",
                "YogaBinding",
               // anonymousEnumPrefixes: new List<string>() { "FT_Err" },
               //typedefStrategies: new Dictionary<string, TypedefStrategy>()
               //{
               //    { "FT_Error", TypedefStrategy.AsIs}
               //},
               //notFoundTypesOverrides: new Dictionary<string, string>()
               //{
               //    { "FT_Error", "FT_Err"}
               //},
               //fieldParametersTypeOverrides: new Dictionary<string, string>()
               //{
               //    {"load_flags", "FT_LOAD" },
               //    {"face_flags", "FT_FACE_FLAG" },
               //    {"style_flags", "FT_STYLE_FLAG" },
               //    {"pixel_mode", "FT_Pixel_Mode_" }
               //},
               //preprocessedEnumSearchParameters: new List<EnumSearchParameter>()
               //{
               //    new EnumSearchParameter(){Prefix="FT_LOAD", ExcludePrefix="FT_LOAD_TARGET" },
               //    new EnumSearchParameter(){Prefix="FT_FACE_FLAG" },
               //    new EnumSearchParameter(){Prefix="FT_STYLE_FLAG" }
               //},
               logger: loggerFactory.CreateLogger<BindingGenerator.Generator>()
                );
        }
    }
}
