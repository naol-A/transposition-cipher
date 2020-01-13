namespace transposition_cipher
{
    class DoubleTransposition
    {
        public static string Encrypt(string plain,string key,bool pad)
        {
            string cipher = "";
            string firstCipher = "";

            firstCipher = Columnar.Encrypt(plain, key, pad);
            cipher = Columnar.Encrypt(firstCipher, key, false);

            return cipher;
        }

        //decryption

        public static string Decrypt(string cipher,string key)
        {
            string plain = "";

            plain = Columnar.Decrypt(cipher, key);
            plain = Columnar.Decrypt(plain, key);

            return plain;
        }
    }
}
