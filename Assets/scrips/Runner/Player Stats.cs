
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerstats : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosVidaMaximo;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameObject _panelperdiste;
    private int _recuperarVida = 10;

    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;
    }

    public void SumarVida(int heal)
    {
        _puntosVidaActuales = _puntosVidaActuales + _recuperarVida;
    }

    private void Update()
    {
        if(_puntosVidaActuales >= 80)
        {
            _uiManager.ColorBarra(new Color(68f/255f, 189f/ 255f , 68f/ 255f, 255f));
           
        }


        if( (40<= _puntosVidaActuales) && (_puntosVidaActuales < 80))
        {
            _uiManager.ColorBarra(new Color(245f/ 255f, 73f / 255, 39f / 255f, 255f));
        }
        if (_puntosVidaActuales < 40)
        {
            _uiManager.ColorBarra(new Color(212f/ 255f, 19f/ 255f, 19f/ 255f, 255f));
        }

        if (_puntosVidaActuales > 100)
        {
            _puntosVidaActuales = 100;
        }

        if (_puntosVidaActuales <= 0)
        {
            Destroy(this.gameObject);
        }

        if (_puntosVidaActuales <=0)
        {
            _panelperdiste.SetActive(true);
        }


        
        

    }


}


// + suma 
// - resta
// * multiplicar

// = asignar
// == comparar
// ! diferente
// && y
// || o

// !=
// -=
// += 
// ++ sumar 1
// -- restar 1