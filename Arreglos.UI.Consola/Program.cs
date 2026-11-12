using Arreglos.Logica;

//Console.WriteLine("Arreglos\n");

//--------------------------------------
//MiArreglo oMyArreglo = new(5);

//oMyArreglo.Agregar(3);
//oMyArreglo.Agregar(5);
//oMyArreglo.Agregar(7);

//oMyArreglo.Insertar(2, 0);
//Console.WriteLine(oMyArreglo);

//Console.WriteLine("------------------");

//oMyArreglo.Eliminar(1);
//Console.WriteLine(oMyArreglo);
//--------------------------------------

//try
//{
//    for (int i = 0; i < oMyArreglo.N; i++)
//    {
//        oMyArreglo.Agregar(i * 6);

//    }
//    oMyArreglo.Agregar(6);

//    Console.WriteLine(oMyArreglo);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//--------------------------------------

MiArreglo oMyArreglo = new(50000);

try
{
    Console.WriteLine("\nArreglo inicial\n");
    var tiempo1 = DateTime.Now;
    oMyArreglo.Llenar(1, 999999);
    Console.WriteLine(oMyArreglo);
    var tiempo2 = DateTime.Now;
    var restaTiempo = tiempo2 - tiempo1;



    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos");

    Console.ReadKey();

    //Console.WriteLine("\nPares\n");
    //var verPares = oMyArreglo.ObtenerPares();
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    //Console.WriteLine("\nPares ordenados\n");
    //verPares.Ordenar(true);
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    Console.WriteLine("\nObtener primos\n");
    var tiempo3 = DateTime.Now;
    var verPrimos = oMyArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempo4 = DateTime.Now;

    var restaTiempo2 = tiempo4 - tiempo3;



    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos");
    Console.ReadKey();

    Console.WriteLine("\nPrimos ordenados burbuja\n");
    verPrimos.Ordenar();
    Console.WriteLine(verPrimos);
    Console.ReadKey();


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




////oMyArreglo.ToString();
//Console.WriteLine("\nArreglo desordenado");
//Console.WriteLine(oMyArreglo);

//Console.WriteLine("\nArreglo ordenado ascendente");
//oMyArreglo.Ordenar();
//Console.WriteLine(oMyArreglo);

//Console.WriteLine("\nArreglo ordenado descendente");
//oMyArreglo.Ordenar(false);
//Console.WriteLine(oMyArreglo);

Console.ReadKey();
