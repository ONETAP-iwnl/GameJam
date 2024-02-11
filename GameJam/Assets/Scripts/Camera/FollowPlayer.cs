using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ игрока
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Смещение камеры относительно игрока

    void LateUpdate()
    {
        if (player != null)
        {
            // Устанавливаем позицию камеры равной позиции игрока с учетом смещения
            transform.position = player.position + offset;
        }
    }
}
