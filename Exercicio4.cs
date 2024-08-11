using System;

namespace Tp1CSharp
{
    public delegate void TemperaturaCritica (string alerta);
    public class Exercicio4
    {
        public event TemperaturaCritica AlertaDelegate;
        
        public void EnviarAlerta ()
        {
            if (AlertaDelegate != null)
            {
                AlertaDelegate("Temperatura em estado crítico!");
            }
        }
    }

    public class ClienteExercicio4 ()
    {
        public void RecebeAlerta (string alerta)
        {
            Console.WriteLine($"Novo alerta: {alerta}");
        }
    }
}
