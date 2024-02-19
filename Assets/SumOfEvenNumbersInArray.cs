using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� � �������� �������"
    /// </summary>
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � �������� �������: {got} - {message}");
    }

    /// <summary>
    /// ����� ��������� ����� ������ ����� � ������� 
    /// </summary>
    /// <param name="array">�������� ������ �����</param>
    /// <returns>����� ����� ������ �����</returns>
    private int SumEvenNumbersInArray(int[] array)
    {
        // ���������� ������� ������ ����� ��������� ���� �
        // ������� ������ 0 ���������� ��������� 
        int sum = 0;
        foreach(int i in array)
        {
            if( i % 2 == 0 )
            {
                sum += i;
            }
        }
        return sum;
    }
}
