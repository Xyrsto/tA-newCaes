namespace tA_Caes.Models
{
    /// <summary>
    /// Descrição das raças de cães
    /// </summary>
    public class Racas
    {
        public Racas() 
        {
            listaAnimais = new HashSet<Animais>();
            listaCriadores = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Denominação da raça
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Lista dos animais associados à raça
        /// </summary>
        public ICollection<Animais> listaAnimais { get; set; }

        /// <summary>
        /// Lista dos criadores associados à raça
        /// </summary>
        public ICollection<Criadores> listaCriadores { get; set; }    
    }
}
