using UnityEngine;

public class Recuperarvida : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.Restaurarvida(10);
            _uiManager.SumarFillAmount(0.1f);
            Destroy(this.gameObject);
        }
        
    }
}