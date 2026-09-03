using Unity.VisualScripting;
using UnityEngine;

public class heal : MonoBehaviour
{

    [SerializeField] private Playerstats _playerstats;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player");
       {
            _playerstats.restaurarVida(10);
            Destroy(this.gameObject);
       }

    }

} 