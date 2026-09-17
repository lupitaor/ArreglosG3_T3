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
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);

            }
            _tope = N;

        }

        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacío");
            }

            string salida = string.Empty;
            for (int i = 0; i < N; i++)
            {
                salida += $"{_arreglo[i]}\t";
            }

            return salida;
        }


    }
}
