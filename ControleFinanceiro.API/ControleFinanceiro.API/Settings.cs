using System;

namespace ControleFinanceiro.API
{
    public static class Settings
    {
        public static string ChaveSecreta = Guid.NewGuid().ToString(); // gerando valor aleatorio
    }
}
