using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image barra;

    private void Start()
    {
        barra.color = Color.cyan;
        barra.fillAmount = 0.5f;
    }
}
