using UnityEngine;

public class PanelVictoria : MonoBehaviour
{
    [SerializeField] private Playerstats _Playerstats;
    [SerializeField] private UIManager UIManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject _panelVictoria;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _gameManager.PausarElJuego();
            _panelVictoria.SetActive(true);
        }
    }

} 