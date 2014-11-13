/*
 * Created by SharpDevelop.
 * User: oscar hernandez
 * Date: 13/11/2014
 * Time: 11:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lector_CVS
{
	/// <summary>
	/// Description of R_cvs.
	/// </summary>
	public class R_cvs
	{
		public static void public static void Main(string[] args)
		{
			
			Console.WriteLine("Ingresa el texto:");
			
     		String ruta;
     		ruta=Console.ReadLine();
      		Console.WriteLine("Texto introducido: " + ruta);
      
      		    StreamReader objReader = new StreamReader("c:\\Users\OSCAR HERNANDEZ\Documents\SharpDevelop Projects\Lector CVS\csv_ejemplo.csv");	
      		    
      		if (Equals ( "C:\Users\OSCAR HERNANDEZ\Documents\SharpDevelop Projects\Lector CVS",ruta )){
					string linea="";
					ArrayList arrText = new ArrayList();
	
				while (linea != null){
					   linea = objReader.ReadLine();
					     if (linea != null){
						    arrText.Add(linea);
						    }
       			 	  Console.WriteLine("{0}\"", sLine.Replace(",", "\n"));
					  }
                        objReader.Close();

               foreach(string salida_Output in arrText){
					     Console.WriteLine(salida_Output);
                        }
		
      		}else Console.WriteLine("Archivo no existe");
			
		}
	}
}
