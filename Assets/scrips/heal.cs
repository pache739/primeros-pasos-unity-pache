using UnityEngine;

public class Recuperarvida : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.Restaurarvida(10);
            Destroy(this.gameObject);
        }
        
    }
}