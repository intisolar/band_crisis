using UnityEngine;

// Clase hija para los jugadores
public class PlayerStats : CharacterStats
{
    protected override void Start()
    {
        base.Start();
        // Aqu� podr�as poner cosas espec�ficas para los jugadores
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("El jugador ha muerto. Mostrar pantalla de Game Over.");
        // Aqu� puedes mostrar men� de Game Over o reiniciar nivel
    }
}

