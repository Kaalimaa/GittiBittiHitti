using System;
using System.IO;

class Esimerkki10_3
{
    static void Main(string[] args)
    {

        //----------------------------------------------------------

        //Ohjelma, joka tulostaa ensin näytölle nykyisen työhakemiston nimen
        //ja pyytää ja lukee sen jälkeen uuden hakemiston nimen, johon se siirtyy ja tulostaa sen sisällön näytölle.

        // string hakemisto = "C:\\Users\\kaali\\Documents\\kansioTexti\\jotainKansio\\";
        string hakemisto = "C:\\Users\\kaali\\Documents\\kouluT\\";
        DirectoryInfo dirInfo = new DirectoryInfo(hakemisto);


        Console.WriteLine("Vanha hakemisto " + dirInfo.FullName);





        //Seuraavassa määrätään hakemiston osoite.
        Console.Write(" Anna uusi hakemiston nimi: ");
        hakemisto = Console.ReadLine();

        DirectoryInfo UusdirInfo = new DirectoryInfo(hakemisto);

        Console.WriteLine("UUSI hakemisto " + UusdirInfo.FullName);

        long tiedostotYhteensä = 0;



        Directory.Exists(hakemisto);    //tarkistaa olemassa olon
                                        //    Jos hakemisto on olemassa, ohjelman tulee tulostaa sen alla olevien tiedostojen koot yhteensä. 
                                        // Console.WriteLine("onko hakemisto olemassa? " + Directory.Exists(hakemisto));


        if (Directory.Exists(hakemisto))
        {


            string[] tiedostoja = Directory.GetFiles(hakemisto);

            foreach (string tiedosto in tiedostoja)
            {
                FileInfo fileInfo = new FileInfo(tiedosto);
                Console.WriteLine(fileInfo.Name + "-tiedoston koko on:" + fileInfo.Length);

                tiedostotYhteensä += fileInfo.Length;

            }
            Console.WriteLine();
            Console.WriteLine("tiedostojen koko yhteensä " + tiedostotYhteensä);

        }
        else
            Directory.CreateDirectory(hakemisto);
        Console.WriteLine("Luodaan hakemisto... ");


        Console.WriteLine("hakemiston nimi: " + Directory.GetCurrentDirectory());

        Console.WriteLine(hakemisto + "-hakemiston luontiaika: " + Directory.GetCreationTime(hakemisto));

    }
}



