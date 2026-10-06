using JetBrains.Annotations;
using UnityEngine;

public class cactusmortal : MonoBehaviour
{ 
[SerializeField] private Gamemanager _gamemanager;
[SerializeField] private GameObject _panelperdiste;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            _gamemanager.pausareljuego();
            _panelperdiste.SetActive(true);






        }
    }
}

