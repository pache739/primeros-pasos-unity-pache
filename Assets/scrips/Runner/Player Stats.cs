using UnityEngine;

public class Playerstats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private UIManager _uiManager;
    private int _recuperarVida = 10;

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void restaurarVida(int heal)
    {
      _puntosVida = _puntosVida + _recuperarVida;
    }

    private void Update()
    {
        if(_puntosVida > 80)
        {
            _uiManager.ColorBarra(Color.green);
        }

        if( (40<= _puntosVida) && (_puntosVida < 80))
        {
            _uiManager.ColorBarra(new Color(1f,1f, 1f, 1f));
        }
        if (_puntosVida< 40)
        {
            _uiManager.ColorBarra(Color.red);
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