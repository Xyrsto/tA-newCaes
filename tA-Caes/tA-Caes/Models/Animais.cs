namespace tA_Caes.Models
{
    /// <summary>
    /// Descrição dos animais(cães)
    /// </summary>
    public class Animais
    {
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
    }
}
