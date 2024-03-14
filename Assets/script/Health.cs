using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    public Animator anim;
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);*/
    }

    private void Awake()
    {
        currentHealth = startingHealth;
        //anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth > 0)
        {
            //player heart
            //anim.SetTrigger("heart");
        }
        else
        {
            if (!dead)
            {
                //anim.SetTrigger("die");
                GetComponent<RoleMove>().enabled = false;
                dead = true;
                SceneManager.LoadScene(4);
                //will not be repeated
            }
            //player dead

        }
    }
}
