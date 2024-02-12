namespace Aruba1930Cli.DTO
{
    public readonly record struct EncryptionSettings
    {
        public bool PasswEncryptEnable { get; init; }
        public required string RsaPublicKey { get; init; }
        public required string LoginToken { get; init; }
    }
}
