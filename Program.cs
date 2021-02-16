using System;

namespace cajero
{

    public class Cajero
    {
        #region variables
        string nombre;
	int saldo;

	

        #endregion
        static void Main(string[] args)
        {

        #region FDP_INVERSMENTS_Cajero_automático
          Cajero persona1 = new Cajero();
		

		Console.WriteLine("Bienvendio a FDP INVERSMENTS Cajero automático");
		Console.WriteLine("");
		Console.WriteLine("Ingresa su Nombre");
		persona1.nombre = Console.ReadLine();
		Console.WriteLine("");
	

		
		
		int res;
		int r;
		do
		{
		Console.WriteLine("¿Qué tipo de transacción deseas realizar?");
		Console.WriteLine("");
		Console.WriteLine("1) - Retiro");
		Console.WriteLine("2) - Salir");

		Console.WriteLine("");
		 

			
		res = int.Parse(Console.ReadLine());
			
		#endregion
		#region switch
		switch(res)
		{
			case 1:
				Console.WriteLine("¿Qué cantidad desea retirar?");
		        int cantidad = int.Parse(Console.ReadLine());
				persona1.retiro(cantidad);
				r=0;
		
				break;
				
			case 2:
				Console.WriteLine("Cerrando sesión " + persona1.nombre);
				Console.WriteLine("Puede retirar su tarjeta " + persona1.nombre);
				Console.WriteLine("....");
				Console.WriteLine("Que tenga un Buen día");
				r=2;
				break;
				
				
			default:
				Console.WriteLine("Esta opción no existe");
				r=0;
				break;
		
		}
		
		}while(r<2);
	
				
	}
    #endregion
	    #region retiro
	
	public int retiro(int cantidad)
	{

				
				if (cantidad % 50 == 0)
				{
					if (cantidad < 20000)
					{
						int milpeso = cantidad / 1000;
						cantidad = cantidad % 1000;
						int quiniento = cantidad / 500;
						cantidad = cantidad % 500;
						int diociento = cantidad / 200;
						cantidad = cantidad % 200;
						int cienpeso = cantidad / 100;
						cantidad = cantidad % 100;
					 

						Console.WriteLine("Le dimos una papeleta 1000 peso " + milpeso);
						Console.WriteLine("Le dimos una papeleta 500 peso " + quiniento);
						Console.WriteLine("Le dimos una papeleta 200 peso " + diociento);
						Console.WriteLine("Le dimos una papeleta 100 peso " + cienpeso);
					}
					else 
					{
						Console.WriteLine("Se ha Exedido el Limite de Transacion");
					}
					
					
				}
              
		return saldo;
	}
    #endregion
	   
}
}


      
   