using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mine : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    protected float _speed = 0.5f;
    [SerializeField]
    protected Vector3 _direction = Vector3.left;
    public AudioSource sauce;
    public AudioClip dropBomb;

    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    virtual protected void FixedUpdate()
    {
        GetRigidbody.MovePosition(GetRigidbody.position + transform.TransformDirection(GetDirection * Time.fixedDeltaTime * _speed));
        if(GetDirection != Vector3.down)
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -90, 90), Mathf.Clamp(transform.position.y, -50, 0), Mathf.Clamp(transform.position.y, -50, 0));
        if (transform.position.y < -50) Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (GetDirection != Vector3.down)
        {
            GetDirection = Vector3.down;
            _speed = 10f;
            collision.rigidbody.GetComponent<Ladrao>().speed = 0f;
            collision.gameObject.transform.parent = transform;
            sauce.PlayOneShot(dropBomb);
        }
    }
}
