using UnityEngine;

public class VictoryOrder : MonoBehaviour
{
    [SerializeField] private Playerstats _Playerstats;
    [SerializeField] private UIManager UIManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject _panelOfvictory;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _gameManager.PausarElJuego();
            _panelOfvictory.SetActive(true);
        }
    }

} 