using UnityEngine;
using UnityEngine.SceneManagement;

public class meta : MonoBehaviour
{
    [SerializeField] private GameObject _panelVictoria;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _panelVictoria.SetActive(true);
            
        }
    }
}