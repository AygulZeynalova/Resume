namespace Services
{
    public interface ICryptoService
    {
        string Encrypt(string value, bool applyUrlEncode);
        string Decrypt(string cipherText);
    }
}
