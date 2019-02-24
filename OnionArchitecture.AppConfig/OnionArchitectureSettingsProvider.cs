using OnionArchitecture.Domain.Settings;

namespace OnionArchitecture.AppConfig
{
    public class OnionArchitectureSettingsProvider: IOnionArchitectureSettingsProvider
    {
        public OnionArchitectureSettings GetSettings()
        {
            return new OnionArchitectureSettings();
        }
    }
}