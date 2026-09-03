using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private Playerstats _Playerstats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _Playerstats.RestarVida(10);
        }
    }
}
