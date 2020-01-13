using System;

namespace transposition_cipher
{
    class Myszkowski
    {
        public static string Encrypt(string plain,string key,bool pad)
        {
            string cipher = "";
            int keyLength = key.Length;
            int plainLength = plain.Length;
            string[] data = new string[keyLength];
            char[] keyCh = new char[keyLength];
            int column = 0, row = plainLength % keyLength != 0 ? (plainLength / keyLength) + 1 : (plainLength / keyLength); ;
            string tempStr = "";
            char tempCh = (char)0;
            Random rnd = new Random();
            int cnt = 1;
            char prevKy = (char)0;

            if (plainLength < keyLength)
            {
                for(int i = 0; i < keyLength - plainLength; i++)
                {
                    plain += " ";
                }
                plainLength = plain.Length;
            }

            foreach (char ch in plain)
            {
                if (column < keyLength)
                {
                    data[column] += ch;
                }
                else
                {
                    column = 0;
                    data[column] += ch;
                }
                column++;
            }
            
            for (int i = 0; i < data.Length; i++)
            {
                if (i != 0)
                {
                    if (data[i].Length < data[i - 1].Length)
                    {
                        if (pad)
                        {
                            data[i] += (char)rnd.Next(65, 90);
                        }
                    }
                }
            }

            for (int i = 0; i < keyLength; i++)
            {
                keyCh[i] = key[i];
            }

            for (int i = 0; i < keyLength; i++)
            {
                for (int j = 0; j < keyLength; j++)
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
                        else if (keyCh[j] == keyCh[j - 1])
                        {

                        }
                    }
                }
            }

            for(int i = 0; i < keyLength; i++)
            {
                tempStr = "";
                if (i == 0)
                {
                    prevKy = keyCh[i];
                }
                else
                {
                    if (prevKy == keyCh[i])
                    {
                        cnt++;
                    }
                    else
                    {
                        if (cnt > 1)
                        {
                            for (int j = 0; j < row; j++)
                            {
                                for(int k = cnt; k > 0; k--)
                                {
                                    if(j < data[i - k].Length)
                                    {
                                        tempStr += data[i - k][j];
                                    }
                                }
                            }
                            cipher += tempStr;
                            cnt = 1;
                        }
                        else
                        {
                            cipher += data[i-1];
                        }
                    }
                    prevKy = keyCh[i];
                }
            }
            if (cnt > 1)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int k = cnt; k > 0; k--)
                    {
                        if (j < data[keyLength - k].Length)
                        {
                            tempStr += data[keyLength - k][j];
                        }
                    }
                }
                cipher += tempStr;
            }
            else
            {
                cipher += data[keyLength - 1];
            }

            return cipher;
        }

        //decryption

        public static string Decrypt(string cipher, string key)
        {
            string plain = "";
            int keyLength = key.Length;
            int cipherLength = cipher.Length;
            string[] data = new string[keyLength];
            char[] keyCh = new char[keyLength];
            int pad = 0, lastCh = 0,row = 0;
            char tempCh = (char)0;
            Random rnd = new Random();
            int cnt = 1;
            char prev = (char)0;

            for (int i = 0; i < keyLength; i++)
            {
                keyCh[i] = key[i];
            }

            if (cipherLength % keyLength != 0)
            {
                pad = (((cipherLength / keyLength) + 1) * keyLength) - cipherLength;
                row = (cipherLength / keyLength) + 1;
            }
            else {
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

            for (int i = 0; i < keyLength; i++)
            {
                if (i == 0)
                {
                    prev = keyCh[i];
                }
                else if (prev == keyCh[i])
                {
                    cnt++;
                }
                else
                {
                    for (int j = 0; j < keyLength; j++)
                    {
                        if (key[j] == prev && cnt == 1)
                        {
                            for (int k = lastCh; k < lastCh + row; k++)
                            {
                                if (j >= keyLength - pad && k < lastCh + (row - 1))
                                {
                                    data[j] += cipher[k];
                                }
                                else if (j < keyLength - pad)
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
                        }
                        else if (key[j] == prev && cnt > 1)
                        {
                            for (int l = 0; l < row; l++)
                            {
                                for (int m = 0; m < keyLength; m++)
                                {
                                    if (key[m] == prev)
                                    {
                                        if (m >= keyLength - pad && l < row - 1)
                                        {
                                            data[m] += cipher[lastCh];
                                            lastCh++;
                                        }
                                        else if (m < keyLength - pad)
                                        {
                                            data[m] += cipher[lastCh];
                                            lastCh++;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                    cnt = 1;
                }
                prev = keyCh[i];
            }

            for (int j = 0; j < keyLength; j++)
            {
                if (key[j] == prev && cnt == 1)
                {
                    for (int k = lastCh; k < lastCh + row; k++)
                    {
                        if (j >= keyLength - pad && k < lastCh + (row - 1))
                        {
                            data[j] += cipher[k];
                            lastCh++;
                        }
                        else if(j < keyLength-pad)
                        {
                            data[j] += cipher[k];
                            lastCh++;
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
                }
                else if (key[j] == prev && cnt > 1)
                {
                    for (int l = 0; l < row; l++)
                    {
                        for (int m = 0; m < keyLength; m++)
                        {
                            if (key[m] == prev)
                            {
                                if (m >= keyLength - pad &&  l < row - 1)
                                {
                                    data[m] += cipher[lastCh];
                                    lastCh++;
                                }
                                else if(m < keyLength-pad)
                                {
                                    data[m] += cipher[lastCh];
                                    lastCh++;
                                }
                            }
                        }
                    }
                    break;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < keyLength; j++)
                {
                    if (j >= keyLength - pad && i < row - 1)
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
