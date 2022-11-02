using System;

public class Class1
{
	private int num1;
	private int num2;

	public Numero()
	{
	}

    public global::System.Int32 Num1 { get => num1; set => num1 = value; }
    public global::System.Int32 Num2 { get => num2; set => num2 = value; }

# Operación sumar
    public double sumar()
    {
        return num1 + num2;

    }
    
    # Operación restar

    public int Resta()
    {
        return num1 - num2;
    }
    
    

    # Operación multiplicar
    public double multiplicacion()
    {
        return num1 * num2;
    }

    #Operación divivir
    public double division()
    {
        return num1 / num2;
    }
    
    }

