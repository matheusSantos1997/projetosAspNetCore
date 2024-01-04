using System.Security.Cryptography;
using System.Text;

namespace CrudContatosMvc.Helper
{
    public static class Criptografia
    {
        public static string GerarHash(this string valor)
        {
            var hash = SHA1.Create();
            var enconde = new ASCIIEncoding();
            var array = enconde.GetBytes(valor);
            array = hash.ComputeHash(array);

            var strHexa = new StringBuilder();

            for(int i = 0; i < array.Length; i++)
            {
                strHexa.Append(array[i].ToString("x2"));
            }

            /*foreach(var item in array)
            {
                strHexa.Append(item.ToString("x2"));
            }*/

            return strHexa.ToString();
        }
    }
}
