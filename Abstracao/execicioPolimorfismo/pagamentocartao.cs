

namespace execicioPolimorfismo
{
    public class pagamentocartao : pagamento
    {
        private float acrecimo = 5.38f;

        public float valorcompra;
        public override float calculartotal()
        {
          float valoracrescimo = valorcompra/ 100 * acrescimo;
          return valorcompra = valorcompra + valoracrescimo;
            
        }
    }
}