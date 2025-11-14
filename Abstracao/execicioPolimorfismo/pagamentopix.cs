

namespace execicioPolimorfismo
{
    public class pagamentopix : pagamento
    {
        public float desconto = 5;

        public float valorcompra;
        public override float calculartotal()
        {
            float valordesconto = valorcompra / 100 * desconto;
            return valorcompra = valorcompra + valordesconto;
        }
    }
}