namespace BlazorKCOidcBff.Server;


public class KeycloakOptions
{
    public string Authority { get; set; } = string.Empty;
    public string ClientId { get; set; } = string.Empty;
    public string[] Scopes { get; set; } = Array.Empty<string>();
}
