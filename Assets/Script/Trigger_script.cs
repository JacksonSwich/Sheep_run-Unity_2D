using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_script : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn; // ������ �������, ������� ��������
    [SerializeField] Transform spawnPoint;    // ����� ��������� (����� ������ � ����������)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���������, ��� ������ ����������� ������ ��� ������� ������� (��������, "Player")
        if (collision.gameObject.CompareTag("Player"))
        {
            Console.WriteLine("������� ��������");
            
            // ������ ������ � �������� �������
            Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);

            // ���� �����, ������� ��� ������� ����� ������������
            // Destroy(gameObject);
        }
    }
}
