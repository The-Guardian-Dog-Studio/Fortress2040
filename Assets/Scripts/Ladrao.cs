using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class Ladrao : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 7.5f;
    [SerializeField]
    protected Vector3 _direction;
    [SerializeField]
    protected LadraoType _type;

    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    virtual protected void FixedUpdate()
    {
        if (speed != 0)
        {
            switch (_type)
            {
                case LadraoType.BOBO:
                    //That's all folks
                    break;
                case LadraoType.USUAL:
                    break;
                case LadraoType.ASTUTO:
                    break;
            }
            GetRigidbody.MovePosition(GetRigidbody.position + transform.TransformDirection(GetDirection * Time.fixedDeltaTime * speed));
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
        } else
        {
            transform.localPosition = Vector3.zero;
        }
        if (transform.position.y < -50) Destroy(gameObject);
        if (transform.position.x < -100) SceneManager.LoadScene(1);
    }


#if UNITY_EDITOR
    public void Validate() => OnValidate();
    public virtual void OnValidate()
    {
        _direction = _direction.normalized;
    }
#endif
}

public enum LadraoType : short
{
    BOBO, USUAL, ASTUTO
}