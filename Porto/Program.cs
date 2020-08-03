using System;

namespace Porto
{
    class Program

    {

        public static double brevX, brevY, brevZ, brevVægt, vægtPris;

        public static string land, pakkeEllerBrev;

        static void Main(string[] args)

        {

            //viden om det en pakke eller brev

            Console.Write("Er det en pakke eller brev du skal sende: ");

            pakkeEllerBrev = Console.ReadLine();

            pakkeEllerBrev.ToLower();



            if (pakkeEllerBrev == "brev")
            {
                //skaffer viden om brevet

                Console.Write("\nLængden på dit brev i cm: ");
                Double.TryParse(Console.ReadLine(), out brevX);
                Console.Write("\nBredden pån dit brev i cm: ");
                Double.TryParse(Console.ReadLine(), out brevZ);
                Console.Write("\nHøjden på dit brev i cm: ");
                Double.TryParse(Console.ReadLine(), out brevY);
                Console.Write("Vægten på dit brev i gram: ");
                Double.TryParse(Console.ReadLine(), out brevVægt);



                Console.Write("Hvilket land skal brevet sendes til: ");
                land = Console.ReadLine();



                størrlser();

                brevetsVægt();



                Console.WriteLine("\nDin pris er:" + vægtPris);



                Console.ReadKey();

            }

            else if (pakkeEllerBrev == "pakke")

            {

                //størrelse på pakken angives

                Console.Write("Længden på din Pakke i cm: ");

                Double.TryParse(Console.ReadLine(), out brevX);

                Console.Write("\nBredden på din Pakke i cm:");

                Double.TryParse(Console.ReadLine(), out brevZ);

                Console.Write("\nHøjden på din Pakke i cm: ");

                Double.TryParse(Console.ReadLine(), out brevY);

                Console.Write("\nVægten på din Pakke i gram: ");

                Double.TryParse(Console.ReadLine(), out brevVægt);



                Console.Write("\nHvilket land skal Pakken sendes til: ");

                land = Console.ReadLine();



                størrlser();

                pakkeVægt();



                Console.WriteLine("\nDin pris er:" + vægtPris);



                Console.ReadKey();

            }

            else

            {

                Console.WriteLine("din kode virker ikke");

            }



        }

        //de forskellige vægt priser

        public static void brevetsVægt()

        {
            land.ToLower();

            if (land == "danmark")
            {
                if (brevVægt <= 50)
                {
                    vægtPris = 10;
                }
                else if (brevVægt >= 50 && brevVægt <= 100)
                {
                    vægtPris = 20;
                }
                else if (brevVægt >= 100 && brevVægt <= 250)
                {
                    vægtPris = 40;
                }
                else if (brevVægt >= 250 && brevVægt <= 2000)
                {
                    vægtPris = 60;
                }
                else
                {
                    Console.WriteLine("dette er for et stort brev");
                }
            }

            else
            {
                if (brevVægt <= 50)
                {
                    vægtPris = 30;
                }
                else if (brevVægt >= 50 && brevVægt <= 100)
                {
                    vægtPris = 30;
                }
                else if (brevVægt >= 100 && brevVægt <= 250)
                {
                    vægtPris = 60;
                }
                else if (brevVægt >= 250 && brevVægt <= 2000)
                {
                    vægtPris = 90;
                }
                else
                {
                    Console.WriteLine("dette er for et stort brev");
                }
            }
        }

        public static void pakkeVægt()

        {

            land.ToLower();

            if (land == "danmark")

            {

                if (brevVægt <= 2000)

                {

                    vægtPris = 50;

                }

                else if (brevVægt >= 2000 && brevVægt <= 5000)

                {

                    vægtPris = 60;

                }

                else if (brevVægt >= 5000 && brevVægt <= 10000)

                {

                    vægtPris = 80;

                }

                else if (brevVægt >= 10000 && brevVægt <= 20000)

                {

                    vægtPris = 100;

                }

                else if (brevVægt >= 20000 && brevVægt <= 35000)

                {

                    vægtPris = 160;

                }

                else

                {

                    Console.WriteLine("dette er for et stort brev");

                }

            }

            else

            {

                if (brevVægt <= 1000)

                {

                    vægtPris = 275;

                }

                else if (brevVægt >= 1000 && brevVægt <= 5000)

                {

                    vægtPris = 517;

                }

                else if (brevVægt >= 5000 && brevVægt <= 10000)

                {

                    vægtPris = 840;

                }

                else if (brevVægt >= 10000 && brevVægt <= 15000)

                {

                    vægtPris = 1244;

                }

                else if (brevVægt >= 15000 && brevVægt <= 20000)

                {

                    vægtPris = 1648;

                }

                else

                {

                    Console.WriteLine("dette er for et stor en pakke");

                }

            }

        }

        //om størelsen er godkendt eller ej

        public static void størrlser()

        {

            if (pakkeEllerBrev == "brev")

            {

                if (brevX <= 60 && brevY <= 60 && brevZ <= 60)

                {

                    Console.WriteLine("\ngodkendt størrelse");

                }

                else

                {

                    Console.WriteLine("\nikke godkendt størrelse");

                }

            }

            else if (pakkeEllerBrev == "pakke")

            {

                if (brevX <= 150 && brevY <= 150 && brevZ <= 150)

                {

                    Console.WriteLine("\ngodkendt størrelse");

                }

                else

                {

                    Console.WriteLine("\nikke godkendt størrelse");

                }

            }

        }

    }

}

