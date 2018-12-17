using System;
namespace colecciones
{
	public class Cita: IEquatable<Cita>, IComparable<Cita>
    {

		public Cita(string persona, string asunto, DateTime fecha){
			this.Persona = persona;
			this.Asunto = asunto;
			this.Fecha = fecha;

		}


        //Cuando guardamos estas instancias en una coleccion, se utiliza este metodo
        //
		public override int GetHashCode(){
			
			return (7 * this.Persona.GetHashCode()) + 
				    (3 * this.Fecha.GetHashCode())+ 
				    (5 * this.Asunto.GetHashCode());
		}

        //Sirve para realizar busquedas
        //Para dos objetos iguales devolvemos true
		public override bool Equals(object obj)
		{
			bool toret = false;

            //comprobamos si obj pertenece a la clase Cita, si no pertenece se crea una referencia a la clase Cita
			if(obj is Cita otraCita){
				toret = (
					this.Fecha == otraCita.Fecha
					&& this.Asunto == otraCita.Asunto
					&& this.Persona == otraCita.Persona
				);
			}

			return toret;
		}

		public bool Equals(Cita otraCita){
			return this.Equals((object)otraCita); //forzamos que se lance el otro equals
		}

		public int CompareTo(Cita otraCita){
			int toret = -1;
			if(!ReferenceEquals(otraCita, null)){
				toret = this.Fecha.CompareTo(otraCita.Fecha);
			}
			//si la fecha fuese igual podemos ordenarlo despues por el asunto
			return toret;
		}

		public static bool operator == (Cita cita1, Cita cita2){
			//cita1??cita1.Equals(cita2); 
            //cita1?.Equals(cita2); //llama a cita1 exclusivamente si cita1 no es null;
			if(ReferenceEquals(cita1, null)){
				return false;
			}

			return cita1.Equals(cita2);
			 
		}

		public static bool operator !=(Cita cita1, Cita cita2)
        {
			return !(cita1 == cita2);
        }

		public static bool operator>(Cita cita1, Cita cita2){
			bool toret = false;

			if(!ReferenceEquals(cita1, null)){
				toret = (cita1.CompareTo(cita2) > 0); 
			}

			return toret;
		}

		public static bool operator <(Cita cita1, Cita cita2)
        {
            bool toret = false;

            if (!ReferenceEquals(cita1, null))
            {
                toret = (cita1.CompareTo(cita2) < 0);
            }

            return toret;
        }



		public DateTime Fecha{
			get; set;
		}

		public string Asunto{
			get; set;
		}

		public string Persona{
			get;set;
		}

		public override string ToString()
		{
			return this.Fecha + ": " + this.Asunto + " (" + this.Persona + ")";
		}
	}
}
