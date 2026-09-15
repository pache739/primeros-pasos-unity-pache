using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
    }

    public void RestartFillAmout(float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
    }

    public void colorBarra(Color myColor)
    {
        _barra.color = myColor;
    }

}
