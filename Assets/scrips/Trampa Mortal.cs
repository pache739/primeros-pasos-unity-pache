using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private Playerstats _playerstats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerstats.RestarVida(10);
        }
    }

}
