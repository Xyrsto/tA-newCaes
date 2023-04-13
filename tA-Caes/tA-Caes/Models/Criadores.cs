using Microsoft.Identity.Client;

namespace tA_Caes.Models
{
    /// <summary>
    /// Descrição dos criadores de animais
    /// </summary>
    public class Criadores
    {
        public Criadores() 
        {
            //inicializar a lista de animais do criador 
            listaAnimais = new HashSet<Animais>();
            listaRacas = new HashSet<Racas>();
        }

        public int id { get; set; }     

        /// <summary>
        /// nome dos criadores
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// nome comercial dos criadores
        /// </summary>
        public string nomeComercial { get; set; }

        /// <summary>
        /// morada dos criadores
        /// </summary>
        public string morada { get; set; }

        /// <summary>
        /// codigo postal dos criadores
        /// </summary>
        public string codPostal { get; set; }

        /// <summary>
        /// email dos criadores
        /// </summary>
        public string email { get; set; } 
        
        /// <summary>
        /// telemovel dos criadores
        /// </summary>
        public string telemovel { get; set;}

        /*
         * relacionamentos associados ao Criador
         */



        /// <summary>
        /// Lista dos animais associados ao Criador
        /// </summary>
        public ICollection<Animais> listaAnimais { get; set; }

        ///<summary>
        ///Lista das raças associados ao criador
        ///</summary>
        public ICollection<Racas> listaRacas { get; set; }


    }
}
