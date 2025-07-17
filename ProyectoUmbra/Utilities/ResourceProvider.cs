using System.Globalization;
using System.Resources;

namespace ProyectoUmbra.Helpers
{
    public static class ResourceProvider
    {
        private static ResourceManager _resourceManager;
        static ResourceProvider()
        {
#if DEBUG
            var resourceFile = "ProyectoUmbra.Resources.Strings.Local";
#else
            var resourceFile = "ProyectoUmbra.Resources.Strings.Public";
#endif
            _resourceManager = new ResourceManager(resourceFile, typeof(ResourceProvider).Assembly);
        }

        public static string GetString(string key) => _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? string.Empty;
    }
}