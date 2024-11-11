using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rope : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public float ropeSpeed = 0.5f;
    private float currentSpeed;
    private bool isReversing = false;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        currentSpeed = ropeSpeed;
        Debug.Log("Rope Setup");
    }

    // Update is called once per frame
    void Update()
    {
        // 현재 애니메이션 상태 정보 가져오기
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // 애니메이션이 종료되었고, 루프가 꺼져 있을 때
        if (stateInfo.normalizedTime >= 1.0f && !isReversing)
        {
            // speed를 -1로 설정하여 반대로 재생
            animator.SetFloat("Speed", ropeSpeed * - 1);
            isReversing = true;
            spriteRenderer.sortingOrder++;
        }

        // 애니메이션이 반대로 재생되는 동안
        if (isReversing)
        {
            // 애니메이션이 끝나면 다시 원래 속도로 설정
            if (stateInfo.normalizedTime <= 0.0f)
            {
                animator.SetFloat("Speed", ropeSpeed);
                isReversing = false;
                spriteRenderer.sortingOrder--;
            }
        }

        //Debug.DrawRay(rigidBody.position, Vector3.down, Color.red);
        //RaycastHit2D raycastHit = Physics2D.Raycast(rigidBody.position, Vector2.down, 1.0f, LayerMask.GetMask("Platform"));
    }

    
}
