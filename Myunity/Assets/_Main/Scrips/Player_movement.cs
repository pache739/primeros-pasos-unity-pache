using UnityEditor;
using UnityEngine; //esto son librerias de unity (osea las cosas para que funcione) 


public class Player_movement : MonoBehaviour
{
    [SerializeField] private float _force = 50f;
    [SerializeField] private float _speed = 20f;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
       if (Input.GetKey(KeyCode.Space)) //esto es para poder presionar un boton 
       {
            _rigidbody2D.AddForce(Vector2.up * _force);
       }
        _rigidbody2D.velocity = Vector2.right * _speed;


    }
}