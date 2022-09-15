using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Knight>(out Knight knight))
        {
            Destroy(gameObject);
        }
    }
}