using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private Playerstats _playerstats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            _playerstats.RestarVida(10);
        }
    }

}
