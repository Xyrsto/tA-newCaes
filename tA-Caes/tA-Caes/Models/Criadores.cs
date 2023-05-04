using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        /// <summary>
        /// nome comercial dos criadores
        /// </summary>
        [Display(Name = "Nome comercial")]
        public string nomeComercial { get; set; }

        /// <summary>
        /// morada dos criadores
        /// </summary>
        [Display(Name = "Morada")]
        public string morada { get; set; }

        /// <summary>
        /// codigo postal dos criadores
        /// </summary>Display(Name = "código postal")
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Código postal")]
        public string codPostal { get; set; }

        /// <summary>
        /// email dos criadores
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string email { get; set; }

        /// <summary>
        /// telemovel dos criadores
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Telemóvel")]
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
