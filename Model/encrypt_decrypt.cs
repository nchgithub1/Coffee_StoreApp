using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CoffeeStore1.Model
{
    public class encrypt_decrypt
    {

        public static string Encode(string inputValue)
        {
            try
            {
                string ourText = inputValue;//"section engineering education";
                string returnValue = null;
                string _key = "abcdefgh";
                string privatekey = "hgfedcba";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(privatekey);
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key);
                byte[] inputtextbyteArray = System.Text.Encoding.UTF8.GetBytes(ourText);
                using (DESCryptoServiceProvider dsp = new DESCryptoServiceProvider())
                {
                    var memstr = new MemoryStream();
                    var crystr = new CryptoStream(memstr, dsp.CreateEncryptor(_keybyte, privatekeyByte), CryptoStreamMode.Write);
                    crystr.Write(inputtextbyteArray, 0, inputtextbyteArray.Length);
                    crystr.FlushFinalBlock();
                    // return Convert.ToBase64String(memstr.ToArray());
                    returnValue = Convert.ToBase64String(memstr.ToArray());
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string Decode(string inputValue)
        {
            try
            {
                string ourText = inputValue;//"bIwl1Y/220KPke+MzXxKErqBT5jkOEbDJnVEPxCzs7I=";
                string x = null;
                string _key = "abcdefgh";
                string privatekey = "hgfedcba";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(privatekey);
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key);
                byte[] inputtextbyteArray = new byte[ourText.Replace(" ", "+").Length];
                //This technique reverses base64 encoding when it is received over the Internet.
                inputtextbyteArray = Convert.FromBase64String(ourText.Replace(" ", "+"));
                using (DESCryptoServiceProvider dEsp = new DESCryptoServiceProvider())
                {
                    var memstr = new MemoryStream();
                    var crystr = new CryptoStream(memstr, dEsp.CreateDecryptor(_keybyte, privatekeyByte), CryptoStreamMode.Write);
                    crystr.Write(inputtextbyteArray, 0, inputtextbyteArray.Length);
                    crystr.FlushFinalBlock();
                    // return Encoding.UTF8.GetString(memstr.ToArray());
                    x = Encoding.UTF8.GetString(memstr.ToArray());
                }
                return x;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}