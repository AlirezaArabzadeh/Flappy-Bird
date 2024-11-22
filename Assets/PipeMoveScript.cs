using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5f; // سرعت حرکت لوله‌ها
    public float deadZone = -45f; // محدوده‌ای که لوله حذف می‌شود

    // Update is called once per frame
    void Update()
    {
        // حرکت لوله به سمت چپ
        MovePipes();

        // حذف لوله اگر از محدوده خارج شود
        CheckDeadZone();
    }

    // تابع حرکت لوله‌ها
    private void MovePipes()
    {
        // تغییر موقعیت لوله به سمت چپ
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    // تابع بررسی و حذف لوله
    private void CheckDeadZone()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); // حذف شیء
        }
    }
}
