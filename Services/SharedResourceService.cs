using System.Reflection;

namespace Try.Services;

public class SharedResourceService {
    private readonly IStringLocalizer labelLocalizer;
    private readonly IStringLocalizer messageLocalizer;

    #region SharedResourceService
    //****************************************
    //Constructor initializes localizers for Label and Message resources using IStringLocalizerFactory
    //enabling the application to fetch localized strings from resource files.
    //****************************************
    public SharedResourceService(IStringLocalizerFactory factory) {
        var assemblyName = new AssemblyName(typeof(Label).GetTypeInfo().Assembly.FullName!);
        labelLocalizer = factory.Create(nameof(Label), assemblyName.Name!);
        var assemblyNames = new AssemblyName(typeof(Message).GetTypeInfo().Assembly.FullName!);
        messageLocalizer = factory.Create(nameof(Message), assemblyNames.Name!);
    }
    #endregion
    
    #region GetLabel
    //****************************************
    // Retrieves the localized string for a given key from the Label resources.
    // Parameters: key for the desired localized string.
    // Returns:localized string corresponding to the provided key.
    //****************************************
    public string GetLabel(string key)
    {
        return labelLocalizer[key];
    }
    #endregion

    #region GetMessage
    //****************************************
    // Retrieves the localized string for a given key from the Message resources.
    // Parameters: key for the desired localized string.
    // Returns:localized string corresponding to the provided key.
    //****************************************
    public string GetMessage(string key)
    {
        return messageLocalizer[key];
    }
    #endregion
}
