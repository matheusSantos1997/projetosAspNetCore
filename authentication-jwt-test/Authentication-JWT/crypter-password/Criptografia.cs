using System;
using System.Security.Cryptography;
using System.Text;

namespace Authentication_JWT.crypter_password
{
    public class Criptografia
    {
          private HashAlgorithm _algoritmo;
          public Criptografia(HashAlgorithm algoritmo)
          {
             _algoritmo = algoritmo;
          }

          public string CriptografarSenha(string senha)
          {
               var encodedValue = Encoding.UTF8.GetBytes(senha);
               var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

               var sb = new StringBuilder();
               foreach (var caracter in encryptedPassword)
               {
                    sb.Append(caracter.ToString("X2"));
               }

               return sb.ToString();
           }

           public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
           {
              if (string.IsNullOrEmpty(senhaCadastrada))
                   throw new NullReferenceException("Cadastre uma senha.");

              var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

              var sb = new StringBuilder();
              foreach (var caractere in encryptedPassword)
              {
                  sb.Append(caractere.ToString("X2"));
              }

              return sb.ToString() == senhaCadastrada;
           }

    }
}