using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;


namespace Llista_9_Ex_11
{
    class Program
    {
        static void DoExercici9(string nomf)
        {
            /*9. A partir d’un fitxer del tipus mostrat ens diu el nom de l’usuari menor.
            (Si dos usuaris tenen la mateixa edat, només en mostra un).
            */
            //declaro el fitxer
            StreamReader f;
            string nom, nomMaxima = "";
            int edat, edatMaxima;

            //ho faig amb el try, perquè si no funciona en pugui capturar l'error
            try
            {
            //obro el fitxer per llegir-lo
            f = new StreamReader(nomf);
            if (!f.EndOfStream)
            {
                nomMaxima = f.ReadLine();
                edatMaxima = int.Parse(f.ReadLine());
                Console.WriteLine($"{nomMaxima} - {edatMaxima}");

                while (!f.EndOfStream)
                {
                    //un readline per el nom, l'altre per l'edat (numero)
                    //de la mateixa manera que llegim per la consola llegim dels fitxers
                    nom = f.ReadLine();
                    edat = int.Parse(f.ReadLine());
                    Console.WriteLine($"{nom} - {edat}");
                    if (edatMaxima > edat)
                    {
                        edatMaxima = edat;
                        nomMaxima = nom;
                    }
                }
                Console.WriteLine($"El més petit és {nomMaxima} ({edatMaxima})");
            }
            else
            {
                Console.WriteLine("Fitxer buit");
            }



            f.Close();
            //el readKey després de tancar el fitxer, així se'ns mostra la info al terminal
            //a l'espera de que apretem qualsevol tecla per seguir amb la següent operació
            Console.ReadKey(true);
             }

            //si entre les claus del try es produeix algun error, això s'anomena excepció
            //podem posar les intruccions dins l'estrucctura try, la e és la
            //"variable" que em porta la informació sobre l'error, i és un objecte la "e"
            //que té moltes propietats
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static void DoExercici1011(string nomf)
        {
            /*10. A partir d’un fitxer del tipus mostrat ens diu la mitjana de les edats.
            11. A partir d’un fitxer del tipus mostrat ens diu el nom del major, el nom
            del menor i la mitjana de les edats de tots.
            */
            //declaro el fitxer
            StreamReader f;
            string nom = "", nomMaxim = "", nomMinim = "";
            int edat = 0, mitjana = 0, comptador = 0, edatMaxima = 0, edatMinima = 1000;

            try
            {
            //obro el fitxer per llegir-lo
            f = new StreamReader(nomf);
            if (!f.EndOfStream)
            {

                while (!f.EndOfStream)
                {

                    //un readline per el nom, l'altre per l'edat (numero)
                    //de la mateixa manera que llegim per la consola llegim dels fitxers
                    nom = f.ReadLine();
                    edat = int.Parse(f.ReadLine());
                    Console.WriteLine($"{edat}");

                    //per agafar l'edat minima ho haig de fer abans
                    //de l'edat màxima
                    if (edat < edatMinima)
                    {
                        edatMinima = edat;
                        nomMinim = nom;
                    }
                    //l'edat màxima l'agafem aquí
                    if (edat > edatMaxima)
                    {
                        edatMaxima = edat;
                        nomMaxim = nom;
                    }
                    mitjana = mitjana + edat;
                    //poso un comptador, i dividiré la suma total de les edats pel comptador
                    //per obntenir la mitjana
                    comptador++;


                }
                Console.WriteLine($"El més gran és: {nomMaxim} - {edatMaxima}, el més petit és: {nomMinim} - {edatMinima}, La mitjana és = {(mitjana) / comptador}");
            }
            else
            {
                Console.WriteLine("Fitxer buit");
            }

            f.Close();
            Console.ReadKey(true);
        }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static void DoExercici12(string nomf)
        {
            //12. A partir d’un fitxer el mostrem tot en majúscules.
            //He utilitzat el mateix fitxer per tots els exercicis fins el moment.
            StreamReader f;
            try
            {
            f = new StreamReader(nomf);
            int edat;
            string nom;
            if (!f.EndOfStream)
            {

                while (!f.EndOfStream)
                {

                    //un readline per el nom, l'altre per l'edat (numero)
                    //de la mateixa manera que llegim per la consola llegim dels fitxers
                    nom = f.ReadLine();
                    edat = int.Parse(f.ReadLine());
                    //fem que el nom estigui en majúscules
                    Console.WriteLine($"{(nom.ToUpper())} - {edat}");
                }
            }
            f.Close();
            Console.ReadKey(true);
        }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static string ElPrimerCaracterMajuscula(string nom)
        {

            //utilitzem la funcio del llenguatge i si l'string es buit retorna null
            if (string.IsNullOrEmpty(nom))
            {
                return null;
            }

            //d'altra banda retorna el primer caràcter de l'string en majúscula
            //i despres hi afegim l'string amb la funcio substring: Recupera una subcadena de la instancia. 
            //La subcadena empieza en una posición de caracteres especificada ( en aquest cas el caràcter 1) y continúa hasta el final de la cadena.
            return char.ToUpper(nom[0]) + nom.Substring(1);
        }
        /* Una altra manera de fer-ho és amb un array de la seguent manera:
        Como alternativa, puede convertir la cadena en una array de caracteres y convertir el primer carácter a mayúsculas. 
        Luego, construya una nueva cadena usando el constructor de strings.

        {
        if (string.IsNullOrEmpty(nom)) {
            return null;
        }
 
        char[] chars = nom.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        return new string(chars);
    }
}
        */

        static void DoExercici13(string nomf)
        {
            /*13. A partir d’un fitxer el mostrem la primera lletra (primer caràcter) de cada
            línia en majúscula i les altres en minúscula.
            */
            StreamReader f;
            try {
            f = new StreamReader(nomf);
            int edat;
            string nom;
            if (!f.EndOfStream)
            {

                while (!f.EndOfStream)
                {

                    //un readline per el nom, l'altre per l'edat (numero)
                    //de la mateixa manera que llegim per la consola llegim dels fitxers
                    nom = f.ReadLine();
                    edat = int.Parse(f.ReadLine());
                    nom = ElPrimerCaracterMajuscula(nom);
                    Console.WriteLine(nom);
                    //fem que el nom estigui en majúscules

                }
            }
            f.Close();
            Console.ReadKey(true);
         }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static void DoExercici14(string nomf)
        {
            //14. A partir d’un fitxer i una paraula, mostrem totes les línies del fitxer que contenen la paraula
            //(grep)
            string paraula;
            StreamReader f;
            string linia;

            //primer de tot demanem una paraula (o conjunt de caràcters) a l'usuar i la llegim
            Console.WriteLine(" Paraula a buscar -> ");
            paraula = Console.ReadLine();

        try {
            f = new StreamReader(nomf);
            while (!f.EndOfStream)
            {
                linia = f.ReadLine();
                //mentre el fitxer està obert, amb la funció contains mirem si hi 
                //és la paraula que estem buscant
                if (linia.Contains(paraula))
                    Console.WriteLine(linia);
            }

            f.Close();
            Console.ReadKey(true);
        }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
            
        }

        static void DoExercici15 (string nomf){
            //15. A partir d’un fitxer en generem un altre amb el mateix nom afegint-hi .cesar amb el mateix
            //text però canviant cada lletra per la següent (en cas de ser z posarem a).
            char missatge =' ';
           
            //del fitxer que llegirem
            StreamReader fr;
            //del fitxer on escriurem
            StreamWriter fw;

            //l'ordre amb que obrim i tanquem els fitxers és igual
            //l'important és on escrivim i llegim, posar-ho bé
            try {
            fr = new StreamReader(nomf);
            //creo el fitxer d'escriptura
            fw = new StreamWriter(@".\textCesar.txt");

            while (! fr.EndOfStream) {

            //Fem que interpreti l'string que llegeix com a caràcters
            //al ser Read retorna un valor enter com a ASCII, per això el podem intepretar com a char
            //en canvi el ReadLine no podem perquè ens retorna un string
            missatge = (char)(fr.Read());

            //llegim la linia, l'string del primer fitxer i escrivim al segon
            //fitxer les lletres +1 de la taula ASCII
                if (missatge >= 'A' && missatge <= 'Z' ) {
                missatge = (char)(((missatge-'A'+1) % ('Z'-'A' +1))+'A');
                
            }
                if (missatge >= 'a' && missatge <= 'z' ) {
                missatge = (char)(((missatge-'a'+1) % ('z'-'a' +1))+'a');
                
            }
                fw.Write(missatge);
                
            }
            //mostro un missatge per pantalla quan ja s'han realitzat les operacions
            Console.WriteLine("OPERACIÓ REALITZADA AMB ÈXIT");
            //hem de tancar els dos fitxers
            fr.Close();
            fw.Close();
            Console.ReadKey(true);

            }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static int InventarNumero(){
            //genero un número aleatori per l'exercici 16
            Random r = new Random();
            int aleatori = r.Next(1,21);
            return aleatori; 
        }
        static void DoExercici16 () {
            /*16. Fes que el programa hagi d'inventar-se un número i tu l'has d'endevinar. Et demana el nom abans de
            començar cada partida, i afegeixi el teu nom i el temps que has trigat a un arxiu on hi consta
            l’historial de partides.
            He afegit un comptador per saber els intents realitzats, i deixarem un màxim de 10 intents;
            */
            int intents=0, numero=0, aleatori = InventarNumero();
            string nom=" ";
            /*això serà per calcular el temps que triga l'usuari en fer
            la partida i es guardarà al fitxer historial de partides
            per poder comptar el temps hem d'utilitzar using System.Diagnostics;
            */
            Stopwatch timeMeasure = new Stopwatch();
            StreamWriter fw;

            try {
            fw = new StreamWriter(@".\Historial Partides.txt", true);
            Console.WriteLine("Nombre d'intents 10");
            Console.WriteLine("ESCRIU EL TEU NOM");
            nom = Console.ReadLine();
            //guardem el nom del jugador al fitxer on guardem les dades de la partida
            fw.WriteLine($"Nom del jugador: {nom}");

            /*un DO WHILE, mentre el número no sigui trobat o no es superin els 10 
            intents es realitzarà la iteració
            */
            
          do {
                Console.WriteLine("ENDEVINA el número 1-20");
                //comencem a comptar el temps mentre l'usuari ja pot entrar el primer número
                timeMeasure.Start();
                numero = int.Parse(Console.ReadLine());
                fw.WriteLine($"Has provat el número: {numero}");
                intents++;
            } while ( numero != aleatori && intents < 10);
            //Si s'ha trobat el número salta aquest missatge
            if (intents < 10) {
            //parem de comptar el temps, la partida ha acabat
            timeMeasure.Stop();
            Console.WriteLine($"Temps de partida: {timeMeasure.Elapsed.TotalSeconds} segons");
            fw.WriteLine($"Temps de partida: {timeMeasure.Elapsed.TotalSeconds} segons");
            Console.WriteLine($"FELICITATS! Has trobat el {numero} i has realitzat: {intents} intents");
            fw.WriteLine($"FELICITATS! Has trobat el {numero} i has realitzat: {intents} intents");
            //Si s'ha superat el nombre d'intents permesos sense trobar el número ens surt aquest missatge
            } else {
                //parem de comptar el temps, la partida ha acabat
                timeMeasure.Stop();
                Console.WriteLine($"Temps de partida: {timeMeasure.Elapsed.TotalSeconds} segons");
                fw.WriteLine($"Temps de partida: {timeMeasure.Elapsed.TotalSeconds} segons");
                Console.WriteLine("GAME OVER, has superat el nombre d'intents permesos");
                fw.WriteLine("GAME OVER, has superat el nombre d'intents permesos");
            }
            
            //tanquem el fitxer
            fw.Close();
            Console.ReadKey(true);
             
           
            } catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static void DoExercici17 (string nomf) {
            //17. Donat un arxiu de text, que conté un text, dir quantes vegades apareix cada lletra o caràcter. Quantes
            //a's, quantes b's,...
            char lletra, missatge;
            int comptadorLletra=0;
            StreamReader f;
            

            //primer de tot demanem una lletra o caràcter a l'usuari i la llegim
            Console.WriteLine(" Caràcter a comptar (es fa distinció entre majúscula i minúscula)-> ");
            lletra = char.Parse(Console.ReadLine());

        try {
            f = new StreamReader(nomf);
            while (!f.EndOfStream)
            {
                missatge = (char)(f.Read());
                //comparem el caràcter entrar per l'usuari amb tots els caràcters del fitxer
                if (missatge == lletra)
                    comptadorLletra++;
            }
            //escrivim quantes vegades troba el programa el caràcter buscat per l'usuari
            Console.WriteLine($"Hi ha: {comptadorLletra} caràcter '{lletra}'");
            f.Close();
            Console.ReadKey(true);
        }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }

        }
        
        static void DoExercici18 (string nomf) {
            /*18. Fer un programa que donat un fitxer el vagi llegint i generi un fitxer de sortida en format
            html. La primera línia serà un <h1>, la segona un <h2> i a partir de llavors cada vegada línia
            serà un <p>. Recorda que cal tancar les etiquetes.
            */

            string missatge, missatge1, missatge2=null, nom;
            //del fitxer que llegirem
            StreamReader fr;
            //del fitxer on escriurem
            StreamWriter fw;

            //l'usuari tria el títol del nou fitxer html qeu creem
            Console.WriteLine("Quin títol tindrà el nou fitxer html?");
            nom = Console.ReadLine();

            //l'ordre amb que obrim i tanquem els fitxers és igual
            //l'important és on escrivim i llegim, posar-ho bé
            try {
            fr = new StreamReader(nomf);
            //creo el fitxer d'escriptura
            fw = new StreamWriter(@".\fitxerInternet.html");

            //les dues primeres línies que llegeixi 
            //van escrites al fitxer html amb les etiquetes indicades
            missatge = fr.ReadLine();
            missatge1 = fr.ReadLine();

            //he afegit l'estructura bàsica d'un fitxer html
            fw.WriteLine("<html>");
            fw.WriteLine("<head>");
            //afegeixo el títol que li dona l'usuari al fitxer
            fw.WriteLine($"<title>{nom}</title>");
            fw.WriteLine("</head>");
            fw.WriteLine("<body>");
            fw.WriteLine("<h1>" + missatge + "</h1>" );
            fw.WriteLine("<h2>" + missatge1 + "</h2>" );
            

            /*a partir d'aquí, les següents linies del fitxer original llegides 
            tindran la etiqueta <p> al fitxer html creat, al posar-ho dins el while ho fem 
            iterar fins el final del document
            a partir de la tercera linia llegida del fitxer original i guardada al missatge2
            anirà escrit al fitxer html amb l'etiqueta <p>
            */
            while (! fr.EndOfStream) {
            missatge2 = fr.ReadLine();
            fw.WriteLine("<p>" + missatge2 + "</p>" );
            }

            fw.WriteLine("</body>");
            fw.WriteLine("</html>");
            //mostro un missatge per pantalla quan ja s'han realitzat les operacions 
            Console.WriteLine("Fitxer html generat amb ÈXIT");
            //hem de tancar els dos fitxers
            fr.Close();
            fw.Close();
            Console.ReadKey(true);

            }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static void DoExerciciFacturacio () {
            /*faig un programa per veure els beneficis o perdues d'una empresa on agafo el fitxer
            de les dades comtables, amb el seu corresponent any i facturacio, processo aquestes
            dades i les envio a un fitxer amb les estadístiques de facturacio
            */

            //creo els dos fitxers, el que estiraré, i el que retornaré amb les estadístiques
            string titol, any, millorAny=" ", pitjorAny=" ";
            int facturacio, anyBeneficis=0, anyPerdues=0, noBeneficiNoPerdua=0, 
            facturacioMesAlta=0, facturacioMesBaixa = 1000000000, mitjana=0;
            StreamReader fr;
            StreamWriter fw;
        
            try {
                //iniciem els dos fitxers
                fr = new StreamReader(@".\FacturacioAnual.txt");
                fw = new StreamWriter(@".\EstadistiquesFacturacio.txt");
                //el titol del itxer que llegim que el posarem al fitxer que escrivim
                //així podriem treure estadístiques de vàries coses
                titol = fr.ReadLine();
                //mentre el fitxer de lectura no arriba al final
                 while (!fr.EndOfStream){
                    //llegeixo les lçinies amb dades
                    any = fr.ReadLine();
                    facturacio = int.Parse(fr.ReadLine());
                    //per calcular la mitjana
                    mitjana = facturacio + mitjana;
                    //càlcul dels anys amb beneficis i dels anys amb pèrdues i els que no n'hi ha cap dels dos
                    if  (facturacio > 0){
                        anyBeneficis++;
                    } else if (facturacio < 0) {
                        anyPerdues++;
                    } else {
                        noBeneficiNoPerdua++;
                    }
                    //l'any amb més beneficis i l'any amb més pèrdues
                    if (facturacio >= facturacioMesAlta ){
                        facturacioMesAlta = facturacio;
                        millorAny= any;
                    } else if (facturacio <= facturacioMesBaixa) {
                        facturacioMesBaixa = facturacio;
                        pitjorAny =any;
                    }

                 }
                fw.WriteLine($"{titol}");
                fw.WriteLine($"Anys amb beneficis: {anyBeneficis}");
                fw.WriteLine($"Anys amb pèrdues: {anyPerdues}");
                fw.WriteLine($"Anys sense beneficis ni pèrdues: {noBeneficiNoPerdua}\n=========================");
                fw.WriteLine($"Millor any e quant a beneficis: {millorAny}");
                fw.WriteLine($"Pitjor any en quant a pèrdues: {pitjorAny}");
                //càlcul de la mitjana, per saber els anys ho dividim entre tots els comptadors d'anys així obtenim el nombre d'anys analitzats
                fw.WriteLine("La mitjana de beneficis i pèrdues en aquests anys és: " + mitjana / (anyBeneficis + anyPerdues + noBeneficiNoPerdua) );

                Console.WriteLine("FITXER CREAT AMB ÈXIT");
            
            //tanquem els dos fitxers
            fr.Close();
            fw.Close();
            Console.ReadKey(true);
             }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static int NombreTreballadors() {
            //funció per saber la mida que tiondrà l'array

            StreamReader fr;
            int comptador=0;
            

            try {
            //obro el fitxer de lectura
            fr = new StreamReader(@".\NomsPersonal.txt");

            //amb el comptador miro les linies que te mentre les llegeixo
            while (!fr.EndOfStream){
                fr.ReadLine();
                comptador++;
            }
            //tanco el fitxer i retorno el comptador
            fr.Close();
            return comptador;

        }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
                //tots els camins de la funció han de tenir un return
                return comptador;
            }
        }


        static void DoOrdenaTreballadors(){
            //PROCÉS FET AMB ARRAY  
            //agafo un fitxer amb el nom dels treballadors i l'ordeno alabèticament
            //els noms ordenats alfabèticament van a un nou fitxer

            StreamWriter fw;
            StreamReader fr;
           

            try {
                //iniciem els dos fitxers, ja que tinc la mida de l'array, però ara l'hauré d'omplenar
                fr = new StreamReader(@".\NomsPersonal.txt");
                fw = new StreamWriter(@".\NomsPersonalOrdenats.txt");
                //declaro l'array i li passo la funció per saber-ne la mida
                string[] noms = new string[NombreTreballadors()];
            //mentre el fitxer de lectura no acaba anem llegint els noms i guardant-los a l'array
            while (! fr.EndOfStream){
            for(int i = 0; i < noms.Length; i++)
            noms[i] = fr.ReadLine();

               
            }
            //Ordenem els valors de l'array, per defecte els string els posa en ordre alfabètic
            Array.Sort(noms);
            //escrivim els valors guardats a l'array al nou fitxer (els noms)
            for(int i = 0; i < noms.Length; i++)
            fw.WriteLine(noms[i]);
            //avisem qeu ja s'ha realitzat l'operació
            Console.WriteLine("OPERACIÓ REALITZADA AMB ÈXIT");


            fr.Close();
            fw.Close();
            Console.ReadKey(true);

             }
            catch(Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        static int TriaOperacio(){
            //Demanem un número per el menú
            int numero;

            do {
            MostraMenu();
            Console.Write("Entra una opció 0..11 -> ");
            numero = int.Parse(Console.ReadLine());
            return numero;
            } while (numero > 0 && numero <= 11);
            
        }

        static void Main(string[] args)
        {
            //per mirar si existeix un fitxer
            string nomFitxer = @".\fitxer.txt";

            //si exissteix el fitxer fas la funció amb l'exercici
            //si no hi és em dius que no hi és  
            if (File.Exists(nomFitxer))
            {
                int opcio;
                opcio = TriaOperacio();
                while (opcio != 0) {
                // Tracto les dades
                
                switch (opcio) {
                    //demano el número dins el case1 per exemple, no a tots els del switch
                    case 1: DoExercici9(nomFitxer);
                            break;
                    case 2: DoExercici1011(nomFitxer);
                            break;
                    case 3: DoExercici12(nomFitxer);
                            break;
                            
                    case 4: DoExercici13(nomFitxer);
                            break;
                    case 5: DoExercici14(nomFitxer);
                            break;
                    case 6: DoExercici15(nomFitxer);
                            break;
                    case 7: DoExercici16();
                            break;
                    case 8: DoExercici17(nomFitxer);
                            break;
                    case 9: DoExercici18(nomFitxer);
                            break;
                    case 10: DoExerciciFacturacio();
                            break;
                    case 11: DoOrdenaTreballadors();
                            break;
                    
                }
                //mostro el resultat, depenent del tipus que sigui cridarà una funció
                //de mostra resultat o una altra
                
                // Preparo la següent iteracio
                opcio = TriaOperacio();
        }
            }
            else
            {
                Console.WriteLine("El fitxer no existeix");
            }

        }
        static void MostraMenu() {
            
            Console.WriteLine("MENU\n=========================");
            Console.WriteLine("1.- El nom de l’usuari menor d'un fitxer");
            Console.WriteLine("2.- El nom del major, el nom del menor i la mitjana de les edats de tots d'un fitxer");
            Console.WriteLine("3.- A partir d’un fitxer el mostrem tot en majúscules.");
            Console.WriteLine("4.- Mostrem la primera lletra d'un fitxer de cada línia en majúscula i les altres en minúscula.");
            Console.WriteLine("5.- Mostrem totes les línies del fitxer que contenen una paraula en concret d'un fitxer");
            Console.WriteLine("6.- A partir d’un fitxer en generem un altre però canviant cada lletra per la següent");
            Console.WriteLine("7.- El programa s'inventa un número i tu l'has d'endevinar. Les partides i resultats es guarden a un fitxer");
            Console.WriteLine("8.- Quantes vegades apareix cada caràcter o lletra?");
            Console.WriteLine("9.- Llegeix un fitxer i genera un fitxer de sortida en format html.");
            Console.WriteLine("10.- Llegeix números del fitxer i diu quins anys han estat positius i/o negatius en facturació?");
            Console.WriteLine("11.- Ordena el nom dels treballadors alfabèticament");
            Console.WriteLine("\n0.-Sortir");

        }
    }
}
