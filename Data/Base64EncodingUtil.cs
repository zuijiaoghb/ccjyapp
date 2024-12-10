using System;
 
public class Base64EncodingUtil
{
    public static string EncodeToBase64(string input)
    {
        // 将字符串转换为字节数组
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
        
        // 对字节数组进行Base64编码
        string base64String = Convert.ToBase64String(bytes);
        
        return base64String;
     }

    public static string EncodeHexStringToBase64(string input) 
    {
        // 假设input是一个42字节长的16进制字符串        
        byte[] bytes = FromHexStringToByteArray(input);

        // 使用Base64进行编码
        string base64EncodedString = Convert.ToBase64String(bytes);

        return base64EncodedString;
    }

    private static byte[] FromHexStringToByteArray(string hexString)
    {
        if (hexString.Length % 2 != 0)
            throw new ArgumentException(hexString);

        byte[] bytes = new byte[hexString.Length / 2];
        for (int i = 0; i < bytes.Length; i++)
            bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
        return bytes;
    }
}
