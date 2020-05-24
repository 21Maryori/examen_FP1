import java.util.Scanner;

public class EJERCICIO2  {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int bono, puntos, salario_minimo;
        System.out.print("Ingrese el valor de puntos: ");
        puntos = in.nextInt();
        in.nextLine();
        System.out.print("Ingrese el valor de salario minimo: ");
        salario_minimo = in.nextInt();
        in.nextLine();
        bono=0;
        if(puntos<=100)
            bono=(int) (salario_minimo*0.10);
        if(puntos>101&&puntos<=200)
            bono=(int) (salario_minimo*0.50);
        if(puntos>201)
            bono=(int) (salario_minimo*0.100);
        System.out.println("Valor de bono: " + bono);
    }

}