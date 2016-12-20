using UnityEngine;
using CnControls;

// This is merely an example, it's for an example purpose only
// Your game WILL require a custom controller scripts, there's just no generic character control systems, 
// they at least depend on the animations

[RequireComponent(typeof(CharacterController))]
public class movement : MonoBehaviour
{
	public float MovementSpeed = 10f;
	private Transform _mainCameraTransform;
	//private Transform _transform;
	private CharacterController _characterController;
	//modif
	private Rigidbody _Rigidbody;
	public RectTransform _transform;
	public bool _FacingRight = true;    
	//float move;
	//public GameObject stik;
	//

	private void OnEnable()
	{
		_mainCameraTransform = Camera.main.GetComponent<Transform>();
		_characterController = GetComponent<CharacterController>();        
		//_transform = GetComponent<Transform>();
		//
		_Rigidbody = GetComponent<Rigidbody>();
		//_transform = RectTransform.GetComponent<RectTransform>();

		//
	}
	
	public void Update()
	{
		// Just use CnInputManager. instead of Input. and you're good to go
		_Rigidbody.velocity = new Vector3(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
		Vector3 movementVector = Vector3.zero;
		// If we have some input
		if (_Rigidbody.velocity.sqrMagnitude > 0.001f)
		{
			movementVector = _mainCameraTransform.TransformDirection(_Rigidbody.velocity);
			movementVector.y = 0f;
			movementVector.Normalize();
			_Rigidbody.velocity = movementVector;
		}
		movementVector += Physics.gravity;
		_characterController.Move(movementVector*MovementSpeed * Time.deltaTime);
		//var rt = (RectTransform)stik.transform;
		//move = rt.position.x;
		var rt = _transform.anchoredPosition.x;
		//Debug.Log (move);
		if (rt > -25.00006f) {
			// ... flip the player.
			Vector3 theScale = transform.eulerAngles;
			theScale.y = 0;
			transform.eulerAngles = theScale;
            //_anim.SetTrigger("Move");
		}
		// Otherwise if the input is moving the player left and the player is facing right...
		else if (rt < -25.00005f) {
			// ... flip the player.
			Vector3 theScale = transform.eulerAngles;
			theScale.y = 180;
			transform.eulerAngles = theScale;
            //_anim.SetTrigger("Move");
        }
	}
}
