using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private Playerstats _Playerstats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _Playerstats.RestarVida(10);
            _uiManager.RestarFillAmount(0.1f);
        }
    }
}
