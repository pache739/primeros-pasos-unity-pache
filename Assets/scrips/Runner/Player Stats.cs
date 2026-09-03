using UnityEngine;

public class Playerstats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    private int _recuperarVida = 10;

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void restaurarVida(int heal)
    {
      _puntosVida = _puntosVida + _recuperarVida;
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