using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Security.Service
{
    public class HashingAppService
    {
        #region MD5
        public byte[] ComputeHashMD5(byte[] ToBeHash)
        {
            using (var Md = MD5.Create())
            {
                return Md.ComputeHash(ToBeHash);
            }
        }
        public string ComputeHashMD5ToString(string Text)
        {
            return Convert.ToBase64String(ComputeHashMD5(Encoding.UTF8.GetBytes(Text)));
        }
        #endregion

        #region SHA1
        public byte[] ComputeHashSHA1(byte[] ToBeHashed)
        {
            using (var SHA = SHA1.Create())
            {
                return SHA.ComputeHash(ToBeHashed);
            }
        }

        public string ComputeHashSHA1ToString(string Text)
        {
            return Convert.ToBase64String(ComputeHashSHA1(Encoding.UTF8.GetBytes(Text)));
        }
        #endregion

        #region SHA256
        public byte[] ComputeHashSHA256(byte[] ToBeHashed)
        {
            using (var SHA = SHA256.Create())
            {
                return SHA.ComputeHash(ToBeHashed);
            }
        }

        public string ComputeHashSHA256ToString(string Text)
        {
            return Convert.ToBase64String(ComputeHashSHA256(Encoding.UTF8.GetBytes(Text)));
        }
        #endregion

        #region SHA512
        public byte[] ComputeHashSHA512(byte[] ToBeHashed)
        {
            using (var SHA = SHA512.Create())
            {
                return SHA.ComputeHash(ToBeHashed);
            }
        }

        public string ComputeHashSHA512ToString(string Text)
        {
            return Convert.ToBase64String(ComputeHashSHA256(Encoding.UTF8.GetBytes(Text)));
        }
        #endregion
    }
}
