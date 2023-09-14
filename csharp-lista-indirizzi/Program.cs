using System.IO;
using System.Xml.Linq;

namespace csharp_lista_indirizzi
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.GetFullPath(@"./../../../my-addresses.csv");
            List<string[]> fileContent = Helper.GetCSVContent(filePath,",");

            List<Address> addressesList = new List<Address>();

            int rowCounter = 0;
            foreach (string[] row in fileContent) 
            {
                if (rowCounter > 0) 
                {
                    if (row.Length != 6)
                    {
                        Console.WriteLine("Rilevata riga non formattata correttamente. Riga " + rowCounter);
                    }
                    else
                    {
                        // ESTESA
                        /* 
                        string name = row[0];
                        string surname = row[1];
                        string street = row[2];
                        string city = row[3];
                        string province = row[4];
                        string zip = row[5];

                        Address newAddress = new Address(name, surname, street, city, province, zip);
                        addressesList.Add(newAddress);
                        */

                        // ABBREVIATA
                        try
                        {
                            addressesList.Add(new Address(row[0], row[1], row[2], row[3], row[4], row[5]));
                        }catch (Exception ex) 
                        {
                            Console.WriteLine($"Impossibile creare un indirizzo con i dati della riga {rowCounter}"); 
                        }
                        
                    }
                }
                rowCounter++;
            }

            Console.WriteLine($"\n***** Lista degli indirizzi *****\n");
            foreach (Address address in addressesList)
            {
                Console.WriteLine($"Nome: {address.Name}\nCognome: {address.Surname}\nVia: {address.Street}\nCittà: {address.City}\nProvincia: {address.Province}\nCodice postale: {address.ZIP}");
                Console.WriteLine("------------");
            }
        }
    }
}