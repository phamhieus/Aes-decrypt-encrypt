using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AES_File
{
    public class Aes
    {
        //public void encrypt(string filepath, string password)
        //{
        //    byte[] filecontent = file.readallbytes(filepath);
        //    byte[] passwordtmp = encoding.ascii.getbytes(filepath);
        //    byte[] keys = new byte[filecontent.length];

        //    for (int i = 0; i < filecontent.length; i++)
        //    {
        //        keys[i] = passwordtmp[i % passwordtmp.length];
        //    }

        //    // encrypt
        //    byte[] result = new byte[filecontent.length];

        //    for (int i = 0; i < filecontent.length; i++)
        //    {
        //        byte value = filecontent[i];
        //        byte key = keys[i];
        //        int valueindex = -1, keyindex = -1;

        //        for (int j = 0; j < 256; j++)
        //        {
        //            if (abc[j] == value)
        //            {
        //                valueindex = j;
        //                break;
        //            }
        //        }

        //        for (int j = 0; j < 256; j++)
        //        {
        //            if (abc[j] == key)
        //            {
        //                keyindex = j;
        //                break;
        //            }
        //        }

        //        result[i] = table[keyindex, valueindex];
        //    }
        //}
    }
}
