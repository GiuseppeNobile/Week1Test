using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week1Test
{
    public class GestoreFile
    {

        public static void GestisciEvento(object sender, FileSystemEventArgs e)
        {         
            LeggiFile(e);
            ScriviFile(e);
        }
        
        public static void LeggiFile(FileSystemEventArgs e) 
        {
            try
            {
                //apro il file nel percorso specificato
                using (StreamReader reader = File.OpenText(e.FullPath))
                {
                    Console.WriteLine($"Lettura del file {e.Name}:\n");
                    string riga = reader.ReadLine(); //leggo dal file

                    while(riga != null)
                    {
                        Console.WriteLine(riga);
                        riga = reader.ReadLine(); //leggo la riga successiva
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ScriviFile(FileSystemEventArgs e)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(e.FullPath))
                {
                    Console.WriteLine($"Scrivo il file {e.Name}:\n");
                    writer.WriteLine(e); //scrivo sul file
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}
