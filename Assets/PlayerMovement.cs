using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator _playerAnimator;
    public GameObject Player;
    public float speed;
    private Vector3 _moveVector;
    // Start is called before the first frame update
    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
        { 
            Player.transform.position += Player.transform.up * speed * Time.deltaTime; 
            _playerAnimator.SetInteger("xMovement", 1);
            _playerAnimator.SetFloat("speed", speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S)){
            Player.transform.position -= Player.transform.up * speed * Time.deltaTime;
            _playerAnimator.SetInteger("xMovement", -1);
            _playerAnimator.SetFloat("speed", speed * Time.deltaTime);
        }
        else if(Input.GetKey (KeyCode.A)) 
        { 
            Player.transform.position -= Player.transform.right * speed * Time.deltaTime; 
            _playerAnimator.SetInteger("yMovement", -1);
            _playerAnimator.SetFloat("speed", speed * Time.deltaTime);
        }
        else if(Input.GetKey (KeyCode.D)) 
        { 
            Player.transform.position += Player.transform.right * speed * Time.deltaTime;
            _playerAnimator.SetInteger("yMovement", 1);
            _playerAnimator.SetFloat("speed", speed * Time.deltaTime);
        }     
        else{
            _playerAnimator.SetInteger("xMovement", 0);
            _playerAnimator.SetInteger("yMovement", 0);
            _playerAnimator.SetFloat("speed", 0);

        }
    }
}
