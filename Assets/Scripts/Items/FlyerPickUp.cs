using UnityEngine;

public class FlyerPickUp : ItemPickUp, IPickup
{
    public void OnPickup()
    {
        //Rellenar energ�a
        throw new System.NotImplementedException();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //recuperar energ�a
        OnPickup();
    }
}
