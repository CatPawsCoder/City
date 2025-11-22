using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject playerCar;
    public Vector3 offset = new Vector3(0, 5, -10); // Смещение камеры

    void Start()
    {
        playerCar = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate() // Используем LateUpdate для плавности
    {
        if (playerCar != null)
        {
            // Учитываем поворот машинки
            transform.position = playerCar.transform.position +
                                playerCar.transform.TransformDirection(offset);

            // Смотрим на машинку
            transform.LookAt(playerCar.transform);
        }
    }
}