using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace lightojPDF {
    class Program {
        static void Main(string[] args) {
            StreamReader read = new StreamReader("..\\..\\input.txt");
            string line;
            string[] words;
            while ( ( line = read.ReadLine()) != null ) {
                words = line.Split( ' ' );
                WebClient webClient = new WebClient();
                webClient.DownloadFile( words[0], words[1] );
                Console.WriteLine("Downloading File \"{0}\"\n", words[1] );
                Console.WriteLine("Successfully Downloaded File \"{0}\"\n", words[1] );
            }
        }
    }
}
