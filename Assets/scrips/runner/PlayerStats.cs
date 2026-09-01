
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    public void RestarVida()
    {
        _puntosVida = _puntosVida - 10;
    }
}