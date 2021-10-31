using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MainChar : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    protected float _maxSpeed = 10;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected Vector3 _direction;
    private MC _controls;
    public GameObject trap;
    public GameObject vaia;
    public AudioSource sauce;
    public AudioClip dropBomb;
    public AudioClip vaia1;
    public AudioClip vaia2;
    public bool canTrap = true;
    public bool canVaia = true;
    private WaitForSeconds tCooldown = new WaitForSeconds(3);
    private WaitForSeconds vCooldown = new WaitForSeconds(5);

    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }

    public void Awake()
    {
        _controls = new MC();
        _controls.Reporter.Move.performed += ctx => { OnMove(); };
        _controls.Reporter.Move.canceled += ctx => { OnMoveStop(); };
        _controls.Reporter.Trap.performed += ctx => { OnTrap(); };
        _controls.Reporter.Vaia.performed += ctx => { OnVaia(); };
    }

    void OnMove()
    {
        GetDirection = (Vector3)_controls.Reporter.Move.ReadValue<Vector2>();
        _speed = _controls.Reporter.Move.ReadValue<Vector2>().magnitude * _maxSpeed;
    }
    void OnMoveStop()
    {
        _speed = 0;
    }
    void OnTrap()
    {
        if (canTrap)
        {
            sauce.PlayOneShot(dropBomb);
            Instantiate(trap, transform.position, Quaternion.identity);
            StartCoroutine(TrapCooldown());
        }
    }
    void OnVaia()
    {
        if (canVaia)
        {
            sauce.PlayOneShot(Random.value < 0.5 ? vaia1 : vaia2);
            Instantiate(vaia, transform.position, Quaternion.identity);
            StartCoroutine(VaiaCooldown());
        }
    }
    IEnumerator TrapCooldown()
    {
        canTrap = false;
        yield return tCooldown;
        canTrap = true;
    }
    IEnumerator VaiaCooldown()
    {
        canVaia = false;
        yield return vCooldown;
        canVaia = true;
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        GetRigidbody.MovePosition(GetRigidbody.position + transform.TransformDirection(GetDirection * Time.fixedDeltaTime * _speed));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -90, 90), Mathf.Clamp(transform.position.y, -50, 0), Mathf.Clamp(transform.position.y, -50, 0));
    }

    public void OnEnable()
    {
        _controls.Enable();
    }

    public void OnDisable()
    {
        _controls.Disable();
    }


#if UNITY_EDITOR
    public void Validate() => OnValidate();
    public virtual void OnValidate()
    {
        _direction = _direction.normalized;
    }
#endif
}
