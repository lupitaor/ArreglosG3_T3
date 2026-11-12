namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Campos o atributos
        private int _tope;
        private int[] _arreglo;

        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[n];
            _tope = 0;
        }
        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Métodos
        public void Llenar()
        {
            Llenar(1, 100);

        }


        //Método llenar con parametros
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);

            }
            _tope = N;

        }

        //Método ordenar (burbuja)

        public void Ordenar()
        {
            Ordenar(true);
        }

        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

        //Método cambiar

        public void Cambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;

        }

        //Método agregar
        public void Agregar(int numero)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;

        }

        //Método insertar

        public void Insertar(int numero, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }

            _arreglo[posicion] = numero;
            _tope++;
        }

        //Método Eliminar

        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo esta vacío");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }

        //Método ObtenerPares
        public MiArreglo ObtenerPares()
        {
            int contadorPares = 0;
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    contadorPares++;
                }
            }
            var arregloPares = new MiArreglo(contadorPares);
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    arregloPares.Agregar(_arreglo[i]);
                }
            }
            return arregloPares;
        }

        //Método EsPar
        private bool EsPar(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;

        }

        //Método ObtenerPrimos

        public MiArreglo ObtenerPrimos()
        {
            int contadorPrimos = 0;
            for (int i = 0; i < _tope; i++)
            {
                if (_arreglo[i] == 1) { continue; }
                if (EsPrimo(_arreglo[i]))
                {
                    contadorPrimos++;
                }
            }
            var arregloPrimos = new MiArreglo(contadorPrimos);
            for (int i = 0; i < _tope; i++)
            {
                if (_arreglo[i] == 1) { continue; }
                if (EsPrimo(_arreglo[i]))
                {
                    arregloPrimos.Agregar(_arreglo[i]);
                }
            }
            return arregloPrimos;
        }


        //Método EsPrimo
        private bool EsPrimo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;

        }


        //Método ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacío");
            }
            int contador = 0;
            string salida = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    //salida = salida + "\n";
                    salida += "\n";
                }

            }
            return salida;
        }
    }
}
