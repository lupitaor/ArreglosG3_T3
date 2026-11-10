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

MiArreglo oMyArreglo = new(100);




try
{
    Console.WriteLine("\nArreglo\n");
    oMyArreglo.Llenar();
    Console.WriteLine(oMyArreglo);
    Console.ReadKey();

    Console.WriteLine("\nPares\n");
    var verPares = oMyArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
    verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var verPrimos = oMyArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    Console.ReadKey();

    Console.WriteLine("\nPrimos ordenados\n");
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
