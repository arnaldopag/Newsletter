using System.Collections.Generic;

namespace newsletter.Models
{
    public static class baseDados
    {
        private static List<Usuario> dados = new List<Usuario>(); 

        public static void incluir(Usuario u){
            dados.Add(u);
        }
        
         public static List<Usuario> listar(){
            return dados;
        }
    }
}