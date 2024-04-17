namespace DanielaMora_PrimerTaller.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public String? Descripcion { get; set; }

        public DateTime FechaPromo { get; set; }

        public int BurgerID { get; set; } //clave foranea
        public Burger? Burger { get; set; } 



    }
}
