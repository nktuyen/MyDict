using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyDict
{
    class Crypto
    {
        public static string ToSHA256(string input)
        {
            string output = string.Empty;

            try
            {
                System.Security.Cryptography.SHA256 cryptor = System.Security.Cryptography.SHA256Managed.Create();

                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] outbytes = cryptor.ComputeHash(bytes);
                
                foreach (byte b in outbytes)
                {
                    output += string.Format("{0:x2}", b);
                }
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                output = input;
            }

            return output;
        }
    }
}
