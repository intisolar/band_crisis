using UnityEngine;

public class EnemyStats : CharacterStats
{
    protected override void Start()
    {
        base.Start();
        // Aqu� podr�as inicializar la IA enemiga
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("Un enemigo fue derrotado.");
        // Aqu� podr�as soltar objetos, dar puntos, etc.
    }
}

