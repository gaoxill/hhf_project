using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpareParts.Helpers
{
    public static class MD5
    {
        // md5加密
        public static string MD5Str3(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
                byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2") + "1");
                }
                return sBuilder.ToString();
            }

            return null;

        }
    }
}
