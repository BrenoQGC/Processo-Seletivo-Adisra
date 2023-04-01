
namespace Processo_Seletivo_Adisdra
{
    internal class q4_Carros
    {
        public abstract class Carro
        {
            public string NumeroChassi { get; set; }
            public string NumeroMotor { get; set; }
            public decimal CustoProducao { get; set; }

            public virtual decimal Imposto()
            {
                return CustoProducao * 0.2m;
            }

            public decimal CustoVenda()
            {
                decimal custoTotal = CustoProducao + Imposto() + Lucro();
                return custoTotal;
            }

            protected virtual decimal Lucro()
            {
                return CustoProducao * 0.25m;
            }
        }

        public class CarroFlex : Carro
        {
            public int NumeroPortas { get; set; }
            public decimal Cilindrada { get; set; }

            public override decimal Imposto()
            {
                return CustoProducao * 0.2m;
            }
        }

        public class CarroDiesel : Carro
        {
            public decimal CapacidadeCarga { get; set; }
            public decimal VolumeCacamba { get; set; }

            public override decimal Imposto()
            {
                return CustoProducao * 0.3m;
            }
        }

        public class CarroEletrico : Carro
        {
            public decimal Potencia { get; set; }
            public decimal DuracaoBateria { get; set; }

            public override decimal Imposto()
            {
                return CustoProducao * 0.1m;
            }

            protected override decimal Lucro()
            {
                return base.Lucro() - (CustoProducao * 0.1m);
            }
        }


    }
}
