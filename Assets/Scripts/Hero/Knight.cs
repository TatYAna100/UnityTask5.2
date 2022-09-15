using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Knight : MonoBehaviour
{
    public int Ñoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            Ñoins++;
        }
    }
}