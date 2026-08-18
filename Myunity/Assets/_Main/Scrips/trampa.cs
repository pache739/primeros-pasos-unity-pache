
using UnityEngine;

public class trampa : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) ;
        {
            Destroy(collision.gameObject);
        }
    }
}
