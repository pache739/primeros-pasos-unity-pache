using UnityEngine;

public class Playerstats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
        
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
    }
}
