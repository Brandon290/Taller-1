// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//PUNTO #1 

// Console.WriteLine("Ingrese datos trimestre 1");
// int trimestre1 = Int32.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese datos trimestre 2");
// int trimestre2 = Int32.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese datos trimestre 3");
// int trimestre3 = Int32.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese datos trimestre 4");
// int trimestre4 = Int32.Parse(Console.ReadLine());

// int total = trimestre1+trimestre2+trimestre3+trimestre4;
// Console.WriteLine("Total renta anual : " +total);

// if(total<10000){
//     Console.WriteLine("El total de renta a pagar es: " + (total*0.05)+ " Su impuesto agregado es del 5%");
// }

// if(total>=10000 && total<20000){
//     Console.WriteLine("El total de renta a pagar es: " + (total*0.1) + " Su impuesto agregado es del 10% ");
// }

// if(total>=20000 && total<35000){
//     Console.WriteLine("El total de renta a pagar es: " + (total*0.15)+ " Su impuesto agregado es del 15% ");
// }

// if(total>=35000 && total<45000){
//     Console.WriteLine("El total de renta a pagar es: " + (total*0.2)+ " Su impuesto agregado es del 20%");
// }


// if(total>45000){
//     Console.WriteLine("El total de renta a pagar es: " + (total*0.3)+ " Su impuesto agregado es del 30% ");
// }

//PUNTO #2  
// Console.WriteLine("Ingrese su nombre completo y edad");
// string nombre = Console.ReadLine();
// int edad = Int32.Parse(Console.ReadLine());
// int valorentrada = 15000;

// if(edad<4)Console.WriteLine(nombre + " " + " No tiene valor su entrada, Bienvenido");

// if(edad>=4&& edad<18)Console.WriteLine(nombre + " " + " Valor de entrada 15000$, tiene un descuento de: " + valorentrada*0.05 );

// if(edad>18)Console.WriteLine(nombre + " " + " Valor de entrada 15000$, tiene un descuento de: " + valorentrada*0.03 );

//PUNTO #3

// Console.WriteLine("Bienvenidos a Pizzas el Fercho, Por favor indique que tipo de pizza quiere, vegetariana, no vegetariana");
// string Tipo_pizza =Console.ReadLine();
// string ingrediente;
// if(Tipo_pizza=="vegetariana"){
//     Console.WriteLine("Menu de Pizza vegetariana, por favor eliga un ingrediente: Pimiento y Champiñiones ");
//     ingrediente = Console.ReadLine();
// }else{
//     Console.WriteLine("Menu de Pizza no vegetariana, por favor eliga un ingrediente: Pepperoni, salami y pollo ");
//     ingrediente = Console.ReadLine();
// }
 
// Console.WriteLine("Querido usuario, usted eligio Pizza " + Tipo_pizza + " que tiene los siguientes ingredientes: mozzarella, tomate y " +ingrediente);

//PUNTO #4

// Console.WriteLine("Por favor indique su nota de evaluacion, para validar bono");
// double evaluacion = Convert.ToDouble(Console.ReadLine());

// if(evaluacion==0.0)Console.WriteLine("Su rendimiento fue inaceptable, bonificacion de: " + 50000*0.0);
// if(evaluacion==0.4)Console.WriteLine("Su rendimiento fue aceptable, bonificacion de: " + 50000*0.4);
// if(evaluacion==0.6)Console.WriteLine("Su rendimiento fue meritorio, bonificacion: " + 50000*0.6);

