using System.ComponentModel.DataAnnotations.Schema;

//comandos de criação da BD no terminal
//update-database
//add-migration

namespace tA_Caes.Models
{
    /// <summary>
    /// Descrição dos animais(cães)
    /// </summary>
    public class Animais
    {
        public Animais() 
        {
            listaFotografias = new HashSet<Fotografias>();
        }

        public int id { get; set; }

        /// <summary>
        /// nome dos animais
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// data de nascimento dos animais 
        /// </summary>
        public DateTime dataNascimento { get; set; }

        /// <summary>
        /// data de compra dos animais
        /// </summary>
        public DateTime dataCompra { get; set; } 

        /// <summary>
        /// sexo dos animais
        /// F-Femea
        /// M-Macho
        /// </summary>
        public string sexo { get; set; }

        /// <summary>
        /// numero de LOP dos animais
        /// </summary>
        public string numLOP { get; set; }

        /*
        * Criação das chaves forasteiras
        */
        
        /// <summary>
        /// FK para o Criador do animal
        /// </summary>
        [ForeignKey (nameof(criador))] //dentro dos parentisis fica o nome do atributo da linha 46
        public int criadorFK { get; set; }
        public Criadores criador { get; set; } //efetivamente, esta é que é a FK, para a EntityFramework

        /// <summary>
        /// FK para a raça do animal 
        /// </summary>
        [ForeignKey (nameof(raca))]
        public int racaFK { get; set; }
        public Racas raca { get; set; }

        /// <summary>
        /// lista de fotografias para cada animal
        /// </summary>
        public ICollection<Fotografias> listaFotografias { get; set; }
            

    }
}
