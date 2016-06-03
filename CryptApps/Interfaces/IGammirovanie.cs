using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApps.Interfaces
{
    interface IGammirovanie
    {
        byte[] getEncryptedText(byte[] text, byte[] gamma);
        string[] getEncryptedText2(byte[] text, byte[] gamma);
        byte[] getDecryptArray(byte[] encryptedArray, byte[] gamma);
    }
}
