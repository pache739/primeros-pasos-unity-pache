using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class heal : MonoBehaviour
{

    [SerializeField] private Playerstats _playerstats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player");
       {
            _playerstats.restaurarVida(10);
            _uiManager.SumarFillAmount(0.1f);
            Destroy(this.gameObject);
       }

    }

} 