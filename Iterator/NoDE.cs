using System.Globalization;

namespace Iterator {
    public class NoDE {
        public int Dado{ get; set; }
        public NoDE ProxNoDe;
        public NoDE AntNoDe;

        public NoDE(NoDE proxNoDe = null, NoDE antNoDe = null, int dado = 0)
        {
            ProxNoDe = proxNoDe;
            AntNoDe = antNoDe;
            this.Dado = dado;
        }

        public override string ToString() {
            return Dado.ToString(CultureInfo.InvariantCulture);
        }
    }
}
