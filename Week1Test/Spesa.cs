using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test
{
    public class Spesa : GestoreFile
    {
        
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }

        //COSTRUTTORI
        public Spesa() { }
        public Spesa(DateTime d, string c, string desc, double imp)
        {
            Data = d;
            Categoria = c;
            Descrizione = desc;
            Importo = imp;
        }

        //per verificare la corretta creazione dell'oggetto
        public void visualizzaSpesa() 
        {
            Console.WriteLine("test per verificare la corretta creazione di un oggetto:\n");
            Console.WriteLine($"Data: {Data} \tDescrizione: {Descrizione} \tCategoria: {Categoria } \tImporto: {Importo}");
            
        } 
    }
}
