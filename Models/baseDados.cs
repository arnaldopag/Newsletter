using System.Collections.Generic;

namespace newsletter.Models
{
    public static class baseDados
    {
        private static List<usuario> dados = null; 

        public static void incluir(usario u){
            dados.Add(u);
        }


        public static List<usuario> listar(){
            return dados;
        }
    }
}