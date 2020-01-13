using System;

namespace transposition_cipher
{
    class Columnar
    {
        public static string Encrypt(string plain,string key,bool pad)
        {
            string cipher="";
            int keyLength = key.Length;
            int plainLength = plain.Length;
            string[] data = new string[keyLength];//length of column
            char[] keyCh = new char[keyLength];//key cx array
            int column = 0;
            string tempStr = "";//temp var swap for data
            char tempCh = (char)0;//swap for data tempch
            Random rnd=new Random();

            if (plainLength < keyLength)
            {
                for (int i = 0; i < keyLength - plainLength; i++)
                {
                    plain += " ";
                }
                plainLength = plain.Length;
            }

            foreach (char ch in plain)
            {
                if (column < keyLength)//for 1st row
                {
                    data[column] += ch;
                }
                else//2nd row
                {
                    column = 0;
                    data[column] += ch;
                }
                column++;
            }

            for(int i = 0; i < data.Length; i++)
            {
                if (i != 0)//reg cx add
                {
                if(data[i].Length < data[i - 1].Length)
                    {
                        if (pad)
                        {
                            data[i] += (char)rnd.Next(65, 90);
                        }
                    }
                }
            }

            for (int i = 0; i < keyLength; i++)//assign key to cx
            {
                keyCh[i] = key[i];
            }

            for(int i = 0; i < keyLength; i++)//swap key & plain
            {
                for(int j = 0; j < keyLength; j++)
                {
                    if (j != 0)
                    {
                        if (keyCh[j] < keyCh[j - 1])
                        {
                            tempStr = data[j];
                            data[j] = data[j - 1];
                            data[j - 1] = tempStr;

                            tempCh = keyCh[j];
                            keyCh[j] = keyCh[j - 1];
                            keyCh[j - 1] = tempCh;
                        }
                    }
                }
            }
            foreach(string st in data)
            {
                cipher += st;
            }
            return cipher;
        }

        //decryption

        public static string Decrypt(string cipher,string key)
        {
            string plain = "";
            int keyLength = key.Length;
            int cipherLength = cipher.Length;
            string[] data = new string[keyLength];
            char[] keyCh = new char[keyLength];
            int pad = 0, lastCh=0, row=0;
            char tempCh = (char)0;
            Random rnd = new Random();

            for (int i = 0; i < keyLength; i++)
            {
                keyCh[i] = key[i];
            }

            if (cipherLength % keyLength != 0)
            {
                pad = (((cipherLength / keyLength) + 1) * keyLength) - cipherLength;//#leave space
                row = (cipherLength / keyLength) + 1;//# of row
            }
            else
            {
                row = cipherLength / keyLength;
            }

            for (int i = 0; i < keyLength; i++)
            {
                for (int j = 0; j < keyLength; j++)
                {
                    if (j != 0)
                    {
                        if (keyCh[j] < keyCh[j - 1])
                        {
                            tempCh = keyCh[j];
                            keyCh[j] = keyCh[j - 1];
                            keyCh[j - 1] = tempCh;
                        }
                    }
                }
            }

            for(int i = 0; i < keyLength; i++)
            {
                for(int j = 0; j < keyLength; j++)
                {
                    if (key[j] == keyCh[i] && data[j] == null)
                    {
                        for(int k = lastCh; k < lastCh + row; k++)
                        {
                            if (j >= keyLength - pad && k < lastCh + (row - 1))
                            {
                                data[j] += cipher[k];
                            }
                            else if(j < keyLength-pad)
                            {
                                data[j] += cipher[k];
                            }
                        }
                        if (j < keyLength - pad)
                        {
                            lastCh += row;
                        }
                        else
                        {
                            lastCh += row - 1;
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < keyLength; j++)
                {
                    if (j >= keyLength - pad && i < row-1)
                    {
                        plain += data[j][i];
                    }
                    else if(j < keyLength-pad)
                    {
                        plain += data[j][i];
                    }
                }
            }
            return plain;
        }
    }
}
