using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class PlayerMovement : MonoBehaviour
{
    
    private float jumpTimer;
    public float moveSpeed = 3;
    private bool isJumping = false;
    [SerializeField] bool isGrounded = false;
    //[SerializeField] private UnityEngine.UI.Slider HPBar;
    [SerializeField] private UnityEngine.UI.Slider CDBar;

    [SerializeField] private Rigidbody2D rb;
    public GameObject ACollider;
    public Collider2D BodyCollider;
    [SerializeField] private TrailRenderer tr;

    [SerializeField] private float jumpTime = 0.3f;
    [SerializeField] private float jumpingPower = 10f;

    public float score;
    public int HP;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI AttackCD;
    //public TextMeshProUGUI HPText;
    public GameObject CDBarAll;
    public PauseMenu PMenu;
    
    bool isAlive = true;
    bool canAttack = true;
    float x, y;

    public AudioSource Mizrak;


    Animator animator;
    private void Awake()
    {
        /*HPBar.maxValue = HP;
        HPBar.value = HP;*/
        CDBar.value = 2;


    }
    private void Start()
    {
        Application.targetFrameRate = 60;
        score = 0;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        #region JUMPING
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            isJumping = true;
            rb.velocity = Vector2.up * jumpingPower;
            isGrounded = false;
            //animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical")); zýplama animasyonu gelince uðraþýcam
        }

        if (Input.GetKey(KeyCode.W) && isJumping )
        {
            if(jumpTimer < jumpTime)
            {
                rb.velocity = Vector2.up * jumpingPower;
                jumpTimer += Time.deltaTime;
            } else { isJumping = false; }
        }

        if (Input.GetKeyDown(KeyCode.S) && !isGrounded)
        {
            rb.velocity = Vector2.down * jumpingPower;
            isJumping = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false; jumpTimer = 0f;
        }
        #endregion
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(Attack());
        }

        if (isAlive)
        {
            score += Time.deltaTime * 4;
            ScoreText.text = "SKOR : " + ((int)score).ToString("") + "m";
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PMenu.Pause();
        }

        #region MOVEMENT
        float moveInput = Input.GetAxisRaw("Horizontal");
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector2(moveAmount, 0f));
        #endregion*/
    }

    IEnumerator Attack()
    {
        if (canAttack)
        {
            animator.SetBool("Attack", true); Mizrak.Play();
            ACollider.SetActive(true);
            yield return new WaitForSeconds(0.4f);
            animator.SetBool("Attack", false);
            ACollider.SetActive(false);
            canAttack = false;
            CDBarAll.SetActive(true);
            for (int i = 2; i > 0; i--)
            {
                CDBar.value = i ;
                yield return new WaitForSeconds(1);
            }
            CDBarAll.SetActive(false);
            canAttack = true;
        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (!isGrounded) isGrounded = true;
        }
    }

}