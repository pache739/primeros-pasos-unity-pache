
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosdeVidaMaxio = 100;
    [SerializeField] private UIManager _uiManager;
    private int _recuperarvida = 10;
    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;
    }

    public void Restaurarvida(int heal)
    {
        _puntosVidaActuales = _puntosVidaActuales + _recuperarvida;
    }
    private void Update()
    {
        if (_puntosVidaActuales >= 80)
        {
            _uiManager.colorBarra(Color.green);
        }

        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.colorBarra(new Color(245f, 73f, 39f, 255f));
        }

        if (_puntosVidaActuales < 40)
        {
            _uiManager.colorBarra(new Color(189f, 15f, 15f));
        }

    }
}