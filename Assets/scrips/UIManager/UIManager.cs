using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image barra;
    // Start is called before the first frame update
    void Start()
    {
        barra.color = Color.cyan;
        barra.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
