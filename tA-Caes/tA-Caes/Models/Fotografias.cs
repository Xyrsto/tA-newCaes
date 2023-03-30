namespace tA_Caes.Models
{
    /// <summary>
    /// Fotografias dos cães
    /// </summary>
    public class Fotografias
    {
        public int id { get; set; }

        /// <summary>
        /// Nome do ficheiro 
        /// </summary>
        public string nomeFicheiro { get; set; }

        /// <summary>
        /// nome do local onde a fotografia foi tirada
        /// </summary>
        public string local { get; set; }

        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime dataFotografia { get; set; }
    }
}
