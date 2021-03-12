using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AutomaticAcceptanceTest.Localization
{
    public static class AutomaticAcceptanceTestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AutomaticAcceptanceTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AutomaticAcceptanceTestLocalizationConfigurer).GetAssembly(),
                        "AutomaticAcceptanceTest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
