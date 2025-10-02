using System;

namespace Logger;

public class LoggerSingleton
{
    private static LoggerSingleton instancia;

    private LoggerSingleton()
    {
        Console.WriteLine("Logger inicializado.");
    }

    public static LoggerSingleton GetInstancia()
    {
        if (instancia == null)
        {
            instancia  = new LoggerSingleton();
        }
        return instancia;
    }

    private bool abrirArchivo()
    {
        // Simulate opening a file
        Console.WriteLine("Abriendo archivo de log...");
        return true; // Assume the file opens successfully
    }

    private bool cerrarArchivo()
    {
        // Simulate closing a file
        Console.WriteLine("Cerrando archivo de log...");
        return true; // Assume the file closes successfully
    }   

    public void Log(string message)
    {
        if (abrirArchivo())
        {

            // Simulate writing to a file
            Console.WriteLine($"Mensaje: {message} | Instance HashCode: {this.GetHashCode()}");
            cerrarArchivo();
        }
        else
        {
            Console.WriteLine("No se pudo abrir el archivo de log.");
        }
    }   
}
