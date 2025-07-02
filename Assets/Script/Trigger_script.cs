using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_script : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn; // Префаб объекта, который появится
    [SerializeField] Transform spawnPoint;    // Точка появления (можно задать в инспекторе)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Убедитесь, что объект срабатывает только для нужного объекта (например, "Player")
        if (collision.gameObject.CompareTag("Player"))
        {
            Console.WriteLine("Триггер сработал");
            
            // Создаём объект в заданной позиции
            Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);

            // Если нужно, удалите сам триггер после срабатывания
            // Destroy(gameObject);
        }
    }
}
