using UnityEngine; //esto son librerias de unity (osea las cosas para que funcione) 


public class Player_movement : MonoBehaviour
{
    public float altura = 1.82f;
    public int edad = 30;
    public string nombre = "tripichin";  //estos son datos (hay publicos o privados (si son publicos se pone en minuscula pero si son privados se pone un guion bajo))
    public bool puedevotar = true; 

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D; //esto es de unity
    public Collider2D collider2D;
    public SpriteRenderer spriteRender;
    public Transform transform;

    private void Start()
    {
        Debug.Log("hola: " + nombre +"tu edad es: " +edad + "tu altura es: " +altura  ); //debug es para mostrar mensajes (L en mayuscula)
        rigidbody2D.simulated = false;
        spriteRender.color = Color.red;
        transform.position = new Vector3(-10f, -3f, 0f);
    }


    private void Update()
    {

    }
}