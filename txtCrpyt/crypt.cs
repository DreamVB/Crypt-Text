// A simple class using the TripleDESC encryption to encrypt and decrypt text using a password,
// By DreamVB
using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace DreamVB.txtCrpyt
{
    public class TextCrypt
    {
        private TripleDESCryptoServiceProvider TripleDES;

        private byte[] makePwsHash(string key, int length)
        {
            try
            {
                byte[] _KeyBytes = System.Text.Encoding.Unicode.GetBytes(key);
                SHA1CryptoServiceProvider sh1 = new SHA1CryptoServiceProvider();
                //Make hash of password.
                byte[] hash = sh1.ComputeHash(_KeyBytes);
                //Clear bytes
                Array.Clear(_KeyBytes, 0, _KeyBytes.Length);
                //Return hash trim off extra bytes
                Array.Resize(ref hash, length);
                //Return hash as byte array
                return hash;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string Encrypt(string data)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                //Convert data to byte array
                byte[] _databytes = System.Text.Encoding.Unicode.GetBytes(data);
                //Encrypt the data bytes
                CryptoStream cs = new CryptoStream(ms, TripleDES.CreateEncryptor(),
                    System.Security.Cryptography.CryptoStreamMode.Write);
                cs.Write(_databytes, 0, _databytes.Length);
                //Finish
                cs.FlushFinalBlock();
                //Clear _databytes
                Array.Clear(_databytes, 0, _databytes.Length);
                //Return encrypted data as Base64 string
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Decrypt(string data)
        {
            try
            {
                //Create memory stream
                MemoryStream ms = new MemoryStream();
                //Decode Base64 string
                byte[] _databytes = Convert.FromBase64String(data);
                //Decrypt the _databytes
                CryptoStream cs = new CryptoStream(ms, TripleDES.CreateDecryptor(),
                    System.Security.Cryptography.CryptoStreamMode.Write);
                cs.Write(_databytes, 0, _databytes.Length);
                //Finish
                cs.FlushFinalBlock();
                //Clear _databytes
                Array.Clear(_databytes, 0, _databytes.Length);
                //Return decrypted string
                return System.Text.Encoding.Unicode.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TextCrypt(string password)
        {
            //Creator Crypto service.
            TripleDES = new TripleDESCryptoServiceProvider();
            //Set des key
            TripleDES.Key = makePwsHash(password, TripleDES.KeySize / 8);
            //Set IV
            TripleDES.IV = makePwsHash("", TripleDES.BlockSize / 8);
        }

    }
}
