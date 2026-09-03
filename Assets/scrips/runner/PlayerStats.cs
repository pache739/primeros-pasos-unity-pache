
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    private int _recuperarvida = 10;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void Restaurarvida(int heal)
    {
        _puntosVida = _puntosVida + _recuperarvida;
    }
}