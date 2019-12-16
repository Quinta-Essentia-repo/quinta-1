﻿
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("RPG/Player/Movement")]
    [RequireComponent(typeof(CharacterController))]
    public class Movement : MonoBehaviour
    {
        [Header("Speed Vars")]
        //value Variables
        public float moveSpeed, noise, maxNoise, echoNoise;
        public float walkSpeed, runSpeed, crouchSpeed, jumpSpeed;
        public static float _gravity = 20;
        //Struct - Contains Multiple Variables (eg...3 floats)
        private Vector3 _moveDir;
        //Reference Variable
        public PlayerHandler player;
        private CharacterController _charC;
    public Collider capsule, sphere;
    public Slider noiseBar;
    public Animator animator;
    private void Start()
        {
            _charC = GetComponent<CharacterController>();
        //want to make it do the capsule turns into a sphere when you press crouch thus lowering the profile
        //capsule.SetActive(true);
        _gravity = 20;
        noise = 6f;
        maxNoise = 24f;
    }
    public void Echo()
    {
if (noise <= echoNoise)
        {
            //noise = Vector3.LerpUnclamped(echoNoise, noise, 1f);
        }
    }
        private void Update()
        {
            Move();
        if (noiseBar.value != Mathf.Clamp01(noise / maxNoise))
        {
            GainNoise();
        }
    }
    void GainNoise()
    {
        noise = Mathf.Clamp(noise, 0, maxNoise);
        noiseBar.value = Mathf.Clamp01(noise / maxNoise);

    }
    private void Move()
        {
            if (_charC.isGrounded && !PlayerHandler.isDead)
            {
            //set speed
            if (Input.GetButton("Crouch"))
            {
                animator.SetBool("Moving", true);
                animator.SetBool("Crouching", true);
                animator.SetBool("Running", false);
                noise = 0f;
                moveSpeed = crouchSpeed;
            }

            else if (Input.GetButton("Sprint"))
            {
                animator.SetBool("Moving", true);
                animator.SetBool("Running", true);
                animator.SetBool("Crouching", false);
                moveSpeed = runSpeed;
                noise = 12f;
            }

            else
            {
                animator.SetBool("Crouching", false);
                animator.SetBool("Running", false);
                animator.SetBool("Moving", true);
                moveSpeed = walkSpeed;
                noise = 6f;
            }
                
                _moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
                if (Input.GetButton("Jump"))
                {
                animator.SetTrigger("Jumping");
                _moveDir.y = jumpSpeed;
                noise = 18f;
            }
            }
            if(PlayerHandler.isDead)
            {
                _moveDir = Vector3.zero;
            }
        
        _moveDir.y -= _gravity * Time.deltaTime;
            
           
            _charC.Move(_moveDir * Time.deltaTime);
        }

    }


