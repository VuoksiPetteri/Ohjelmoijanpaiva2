using System;
using OhjelmoijanPaiva.Tree;

namespace OhjelmoijanPaiva
{
    /// <summary>
    /// OhelmoijanPaiva tulee olemaan "tarkka kuvaus" keskiverto ohjelmoijan päivästä....<br></br>
    /// Perinteinen cmd tekstiseikkailu...
    /// </summary>
    class Program
    {
        // Some button constants
        public static readonly char ACTIVATION_LEFT = '0';
        public static readonly char ACTIVATION_RIGHT= '1';


        static void Main(string[] args)
        {
            
            Node End = new Node(null, null, "Rakennus romahti päällesi! Kuolit... Paina 0 tai 1 lopettaaksesi!", new Choise[] { });
            Node layer3_L = new Node(End, End, "Matkataan töihin. Menetkö toimistoosi hissillä.", new Choise[] { new Choise("0: Totta kai"), new Choise("1: Ei arkiliikunta kunniaan!") });
            
            Node layer2_L = new Node(null, null, "Kahvit kaatuivat päällesi ja juostessasi bussille myöhässä kuolit auton alle. Peli loppui! Paina 0 tai 1.", new Choise[] { });

            Node layer1_L = new Node(null, null, "Jäät sänkyyn ja pidät etäpäivän. Tietokone virus iskee sinuun ja kuolet. Peli loppui! Paina 0 tai 1 lopettaaksesi.", new Choise[] { });
            Node layer1_R = new Node(layer2_L, layer3_L, "Manaat koska ohjelmoijienkin pitää noudattaa maatalouden aikoja. Keitetäänkö kahvia?", new Choise[] { new Choise("0: Keitetään vaan"), new Choise("1: Ei kerkiä kiire bussiin.") });
           
            // Root node
            Node root = new Node(layer1_L, layer1_R, "Heräät sängystä. Kello on 04:30.", new Choise[] { new Choise("0: Jää petiin"),new Choise("1: Nouse urheasti")});


            // Game traveler init
            Traveler traveler = new Traveler(root);
            Console.WriteLine("Tervetuloa ohjelmoijan päivään.\n\n");
            
            // Game loop
            while (true)
            {
                traveler.Consume();
                char selection = Console.ReadKey().KeyChar;

                int responseCode = -1;
                if (selection == '0')
                {
                    responseCode = traveler.TravelDown(0);
                }
                else if (selection == '1')
                {
                    responseCode = traveler.TravelDown(1);
                }
                else
                {
                    Console.WriteLine("Invalid option selected.");
                }

                if (responseCode == 0) { break; }
                Console.Write("-----------------------------------------------\n\n\n");
            }

            Environment.Exit(0);
        }
    }
}
