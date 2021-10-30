using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Переменные

    public float speed = 5f; //Скорость передвежения

    private Rigidbody2D rb; // стандартная форма юнити для работы с физикой

    [SerializeField] private Joystick _joystick;

    private bool isFacingRight = true;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); // Для использовани физики в игре
    }

    private void FixedUpdate()
    {

        float moveX = _joystick.Horizontal;
        float moveY = _joystick.Vertical;

        rb.velocity = new Vector2(moveX * speed, moveY * speed);

        if (moveX > 0 && !isFacingRight)

            Flip();

        else if (moveX < 0 && isFacingRight)

            Flip();

    }

    private void Flip() // Функция поворота
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
