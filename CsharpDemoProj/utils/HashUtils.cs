using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

public static class HashUtils
{
    public static string HashString(string text)
    {
        Byte[] bytes = Encoding.UTF8.GetBytes(text);
        using (var sha = SHA256.Create())
        {
            Byte[] hashed = sha.ComputeHash(bytes);
            StringBuilder builder = new StringBuilder();
            foreach (byte b in hashed)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}