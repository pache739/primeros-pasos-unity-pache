
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private UIManager _uiManager;
    private int _recuperarvida = 10;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void Restaurarvida(int heal)
    {
        _puntosVida = _puntosVida + _recuperarvida;
    }
    private void Update()
    {
        if (_puntosVida < 80)
        {
            _uiManager.colorBarra(Color.green);
        }
    }
}