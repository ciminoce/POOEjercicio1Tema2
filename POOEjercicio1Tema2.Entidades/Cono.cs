using System.Text;

namespace POOEjercicio1Tema2.Entidades
{
    public class Cono
    {
        private int _altura;
        private int _radio;
        private double _generatriz;

        public double GetGeneratriz() => _generatriz;
        public int GetAltura() => _altura;
        public int GetRadio() => _radio;
        

        public Cono(int altura, int radio)
        {
            if (altura <= 0 || radio <= 0)
            {
                throw new ArgumentException("Valores mal ingresados");
            }

            _altura = altura;


            _radio = radio;
            _generatriz = SetGeneratriz();
        }

        private double SetGeneratriz()
        {
            return Math.Sqrt(Math.Pow(GetAltura(), 2) + Math.Pow(GetRadio(), 2));
        }

        public double GetArea()
        {
            return Math.PI * GetRadio() * (GetRadio() + GetGeneratriz());
        }

        public double GetVolumen()
        {
            return Math.PI * Math.Pow(GetRadio(), 2) * (GetAltura() / 3);

        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cono");
            sb.AppendLine($"Radio....: {GetRadio()}");
            sb.AppendLine($"Altura...: {GetAltura()}");
            sb.AppendLine($"Generatríz...: {GetGeneratriz():N}");
            sb.AppendLine($"Superficie: {GetArea():N}");
            sb.AppendLine($"Volumen...: {GetVolumen():N}");
            return sb.ToString();
        }

    }
}