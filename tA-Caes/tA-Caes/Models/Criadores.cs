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
        [StringLength(50)]
        public string nome { get; set; }

        /// <summary>
        /// nome comercial dos criadores
        /// </summary>
        [Display(Name = "Nome comercial")]
        [StringLength(50)]
        public string nomeComercial { get; set; }

        /// <summary>
        /// morada dos criadores
        /// </summary>
        [Display(Name = "Morada")]
        [StringLength(200)]
        public string morada { get; set; }

        /// <summary>
        /// codigo postal dos criadores
        /// </summary>Display(Name = "código postal")
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Código postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}( ){1,3}[A-Z -ÓÊÇÁÉÍÚÂÊÎÔÛ]+", ErrorMessage = "Formato Inválido")]
        [StringLength(40)]
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
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Deve escrever {1} dígitos no número de {0}")]
        [RegularExpression("9[1236][0-9]{7}", ErrorMessage = "Número de {0} não válido")] //pode ser ((+ | 00)[0-9]{2,3})? [0-9]{5,9}
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
