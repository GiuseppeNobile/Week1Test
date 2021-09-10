using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Week1Test.Handler;

namespace Week1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ESERCITAZIONE 1

            //spesa di prova
            Spesa spesa1 = new Spesa();                      

            //spesa1.visualizzaSpesa(); // controllo se l'oggetto è stato creato
          
            //Watcher che controlla la cartella Files in attesa del file spese.txt
            FileSystemWatcher fsw = new FileSystemWatcher()
            {
                Path = @"C:\Users\g.nobile\source\repos\Week1Test\Week1Test\Files",
                Filter = "spese.txt"
            };

            fsw.EnableRaisingEvents = true;

            //filtri da controllare
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | 
                               NotifyFilters.CreationTime | NotifyFilters.LastAccess |
                               NotifyFilters.DirectoryName;

            //registrazione all'evento
            fsw.Created += new FileSystemEventHandler(GestoreFile.GestisciEvento);

            #endregion

            #region ESERCITAZIONE 2

            IHandler managerHandler = new ManagerHandler();
            IHandler opmHandler = new OperationalManagerHandler();
            IHandler ceoHandler = new CEOHandler();

            //per determinare l'ordine degli handler
            managerHandler.Successivo(opmHandler).Successivo(ceoHandler);

            //HO AGGIUNTO GLI OGGETTI A MANO NELLA LISTA PERCHE' NON RIESCO A CAPIRE
            //COME PRENDERLI DAL FILE
            List<Spesa> listaSpese = new List<Spesa>
            {
                new Spesa(DateTime.Today, "San Francisco", "Viaggio", 100.5),
                new Spesa(DateTime.Today, "Hotel", "Alloggio", 67.99),
                new Spesa(DateTime.Today, "Alimentari", "Vitto", 45.66),
            };

            Console.WriteLine("Controllo spese:");
            foreach (Spesa item in listaSpese)
            {                
                Console.WriteLine($"{item.Data} \t{item.Categoria} \t{item.Descrizione} \t{item.Importo}\n");
                
                //string risultato = managerHandler.Gestisci(item);
            }
            
            #endregion


        }
    }
}
