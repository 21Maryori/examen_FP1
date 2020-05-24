
Module CALCULARLANOTAFINAL

	Sub Main()
		Dim nota As Double
		Dim nota1 As Double
		Dim nota2 As Double
		Dim nota3 As Double
		Dim nota4 As Double
		Dim notfinal As Double
		' datos de entrada
		Console.WriteLine("ingresar la nota1 ")
		nota1 = Double.Parse(Console.ReadLine())
		Console.WriteLine("ingresar la nota2 ")
		nota2 = Double.Parse(Console.ReadLine())
		Console.WriteLine("ingresar la nota3 ")
		nota3 = Double.Parse(Console.ReadLine())
		Console.WriteLine("ingresar la nota4 ")
		nota4 = Double.Parse(Console.ReadLine())
		' Proceso 
		notfinal = (nota1+nota2+nota3+nota4)/4
		' datos finales
		Console.WriteLine("nota final es : ",notfinal)
	End Sub

End Module
