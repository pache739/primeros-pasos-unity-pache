
using UnityEngine; //esto son librerias de unity (osea las cosas para que funcione) 


public class Player_movement : MonoBehaviour
{
    [SerializeField] private float _force = 10f;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundCheck _groundCheck;

    private void FixedUpdate() // se inicia en el primer frein
    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D.AddForce(Vector2.up * _force);
                Debug.Log("oprimi la tecla");
            }
        }
        _rigidbody2D.velocity = Vector2.right * _speed;
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


}