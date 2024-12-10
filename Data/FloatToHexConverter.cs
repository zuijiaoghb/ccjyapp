using System;

namespace ccjyapp.Data ;

public class FloatToHexConverter
{
    public static string FloatToHexString(float value)
    {
        byte[] bytes = BitConverter.GetBytes(value);
        string hex = BitConverter.ToString(bytes).Replace("-", "");
	return hex;	
    }
}


