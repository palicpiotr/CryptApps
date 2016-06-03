using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApps
{
    interface IPermutations
    {
        Array getEncryptedText(string text, string key);
        Array getDecryptedText(string encryptedText, string key);
    }
}
