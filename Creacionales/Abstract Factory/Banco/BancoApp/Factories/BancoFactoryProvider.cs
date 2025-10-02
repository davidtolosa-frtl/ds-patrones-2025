namespace BancoApp.Factories
{
    public enum TipoPaquete
    {
        Classic,
        Gold,
        Platinum
    }

    public static class BancoFactoryProvider
    {
        public static IBancoProductoFactory ObtenerFactory(TipoPaquete tipoPaquete)
        {
            return tipoPaquete switch
            {
                TipoPaquete.Classic => new ClassicFactory(),
                TipoPaquete.Gold => new GoldFactory(),
                TipoPaquete.Platinum => new PlatinumFactory(),
                _ => throw new ArgumentException($"Tipo de paquete no soportado: {tipoPaquete}")
            };
        }

        public static IBancoProductoFactory ObtenerFactory(string nombrePaquete)
        {
            if (Enum.TryParse<TipoPaquete>(nombrePaquete, true, out var tipoPaquete))
            {
                return ObtenerFactory(tipoPaquete);
            }
            throw new ArgumentException($"Nombre de paquete no válido: {nombrePaquete}");
        }

        public static List<string> ObtenerPaquetesDisponibles()
        {
            return Enum.GetNames<TipoPaquete>().ToList();
        }
    }
}
