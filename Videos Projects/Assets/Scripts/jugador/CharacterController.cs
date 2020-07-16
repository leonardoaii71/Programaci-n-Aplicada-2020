using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CharacterController : MonoBehaviour
{
    Animator characterAnimator;
    Rigidbody2D rigidbody;
    private Vector2 jumpVelocity = new Vector2(2f, 7f);
    private float currentSpeed;
    private Vector3 deltaPos;
    private float maxRunSpeed = 6f;
    private float maxWalkSpeed = 3f;

    // Start is called before the first frame update
    private void Start() {
        AudioManager.Instance.PlayBackGroundMusic(AudioManager.BackgroundMusic.bgmusic1);
    }
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")){
            Jump();
           characterAnimator.SetTrigger("Jump");
           AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Jump);
        }
        if (Input.GetButtonDown("Fire1")){
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire1);
        }
        if (Input.GetButtonDown("Fire2")){
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire2);
        }
        if (Input.GetButtonDown("Fire3")){
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire3);
        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunSpeed : maxWalkSpeed );
        deltaPos.x = currentSpeed * Time.deltaTime;
        
        characterAnimator.SetFloat("Speed", currentSpeed);

        gameObject.transform.Translate(deltaPos);
        Debug.Log(currentSpeed);
        
    }

    public void Jump(){
        rigidbody.velocity = Vector2.up * jumpVelocity;
    }

}
