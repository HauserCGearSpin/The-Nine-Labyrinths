using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

interface IAttackInterface
{
    public void Attack();
}

public class AttackSystem : MonoBehaviour
{
    [Header("Is Attacking Active Bool")]
    [SerializeField] private bool attackingIsActive;

    [Header("Cool Down Floats")]
    [SerializeField] private float coolDownTime;
    [SerializeField] private float maxCoolDownTime;
    [SerializeField] private float coolDownSpeed;

    [Header("Objects")]
    [SerializeField] private Image coolDownBar;
    [SerializeField] private GameObject DefaultCanvas;
    [SerializeField] private PlayerControler player;

    [Header("Interaction Variables")]
    public Transform AttackSource;
    public float attackRange;


    private void Update()
    {
        if (attackingIsActive)
        { 
            Attack();
            CoolDown();
            CoolDownIndicator();
        }

        CheckIfPlayerIsActive();
    }

    void Attack()
    {
        if (coolDownTime == 0)
        {
            AttackInteraction();

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Attack!");
                coolDownTime = maxCoolDownTime;
            }
        }
    }

    void CoolDown()
    {
        if (coolDownTime > 0)
        {
            coolDownTime -= coolDownSpeed * Time.deltaTime;
        }
        if (coolDownTime < 0)
        {
            coolDownTime = 0;
        }
    }

    void CoolDownIndicator()
    {
        coolDownBar.transform.localScale = new Vector3(coolDownTime * 0.3f, 0.03f, 0);
    }

    void AttackInteraction()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray r = new Ray(AttackSource.position, AttackSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, attackRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IAttackInterface interactObj))
                {
                    interactObj.Attack();
                }
            }
        }
    }

    void CheckIfPlayerIsActive()
    {
        if(!player.characterIsActive)
        {
            DefaultCanvas.SetActive(false);
            attackingIsActive = false;
        }
        if (player.characterIsActive) 
        { 
            DefaultCanvas.SetActive(true);
            attackingIsActive = true;
        }
    }
}
