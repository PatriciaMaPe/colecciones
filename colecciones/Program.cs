using System;

namespace colecciones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var horaComida = new DateTime(2018, 11, 27, 14, 00, 00);
			var hora= new DateTime(2018, 11, 27, 16, 00, 00);

			var cita1 = new Cita(fecha: hora, persona:"Patri", asunto:"DIA"); //podemos pasar los agumentos sin orden
            
			var cita2 = new Cita(fecha: horaComida, persona: "Camba", asunto: "Comidita");

			var cita3 = new Cita(fecha: hora, persona: "Patri", asunto: "DIA");

			Console.WriteLine(cita1.GetHashCode() + " -> " + cita1);
			Console.WriteLine(cita2.GetHashCode() + " -> " + cita2);
			Console.WriteLine(cita3.GetHashCode() + " -> " + cita3);

			Console.WriteLine("Cita 1 eq Cita2: " + cita1.Equals(cita2));
			Console.WriteLine("Cita 1 eq Cita3: " + cita1.Equals(cita3));
            
			Console.WriteLine("Cita 1 == Cita2: " + (cita1 == cita2));
			Console.WriteLine("Cita 1 == Cita3: " + (cita1 == cita3));
            
			Console.WriteLine("Cita 1 < Cita2: " + (cita1 < cita2));
            Console.WriteLine("Cita 1 < Cita3: " + (cita1 < cita3));

			Console.WriteLine("Cita 1 > Cita2: " + (cita1 > cita2));
            Console.WriteLine("Cita 1 > Cita3: " + (cita1 > cita3));
        }
    }
}
