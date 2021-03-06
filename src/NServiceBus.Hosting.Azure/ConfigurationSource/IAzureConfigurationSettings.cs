namespace NServiceBus.Integration.Azure
{
    interface IAzureConfigurationSettings
    {
        string GetSetting(string name);
        bool TryGetSetting(string name, out string setting);
    }
}