using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator _playerAnimator;
    public GameObject Player;
    public float speed;
    private Vector3 _moveVector;

    private static readonly int RightMove = Animator.StringToHash("RightMove");
    private static readonly int LeftMove = Animator.StringToHash("LeftMove");
    private static readonly int DownMove = Animator.StringToHash("DownMove");
    private static readonly int UpMove = Animator.StringToHash("UpMove");

    // Start is called before the first frame update
    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Player.transform.position += Player.transform.up * speed * Time.deltaTime;
            _playerAnimator.SetBool(UpMove, true);
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Player.transform.position -= Player.transform.up * speed * Time.deltaTime;
            _playerAnimator.SetBool(DownMove, true);
        }
        if(Input.GetKeyDown(KeyCode.A)) 
        { 
            Player.transform.position -= Player.transform.right * speed * Time.deltaTime; 
            _playerAnimator.SetBool(LeftMove, true);
        }
        if(Input.GetKeyDown(KeyCode.D)) 
        { 
            Player.transform.position += Player.transform.right * speed * Time.deltaTime;
            _playerAnimator.SetBool(RightMove, true);
        }  
        if (Input.GetKeyUp(KeyCode.W) && _playerAnimator.GetBool(UpMove))
        {
            _playerAnimator.SetBool(UpMove, false);
        }
        if(Input.GetKeyUp(KeyCode.S) && _playerAnimator.GetBool(DownMove)){
            _playerAnimator.SetBool(DownMove, false);
        }
        if(Input.GetKeyUp(KeyCode.A) && _playerAnimator.GetBool(LeftMove)) 
        { 
            _playerAnimator.SetBool(LeftMove, false);
        }
        if(Input.GetKeyUp(KeyCode.D) && _playerAnimator.GetBool(RightMove)) 
        { 
            _playerAnimator.SetBool(RightMove, false);
        }     
        
    }
}
