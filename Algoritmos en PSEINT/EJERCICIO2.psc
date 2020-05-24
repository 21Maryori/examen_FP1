Algoritmo  Ejercicio2_L_M_L_C
		
		Escribir Sin Saltar "Ingrese el valor de puntos:";
		Leer puntos;
		Escribir Sin Saltar "Ingrese el valor de salario minimo:";
		Leer salario_minimo;
		bono <- 0;
		Si puntos<=100 Entonces
			bono <- salario_minimo*0.10;
		FinSi
		Si puntos>101 Y puntos<=200 Entonces
			bono <- salario_minimo*0.50;
		FinSi
		Si puntos>201 Entonces
			bono <- salario_minimo*0.100;
		FinSi
		Escribir "Valor de bono: ", bono;

	
FinAlgoritmo
