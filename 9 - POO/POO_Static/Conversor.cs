namespace POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;

        public static float valorUsuario;

        public static float ConverterDolarParaReal(float v)
        {
            return valorUsuario * cotacaoDolar;
        }
        public static float ConversorRealParaDolar(float v)
        {
            return valorUsuario/ cotacaoDolar;
        }
    }
}