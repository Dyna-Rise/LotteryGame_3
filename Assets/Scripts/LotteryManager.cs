using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LotteryManager : MonoBehaviour
{
    public OptionData optionData;

    // Update is called once per frame
    void Update()
    {
        // �h��������]���Ă�����
        if (GameManager.isSpinning == true)
        {
            // ���I���J�n����Ă��Ȃ�(���I�J�n�t���t��OFF)�Ȃ�
            if (GameManager.isLottery == false)
            {
                // ���I�J�n�t���t��ON
                GameManager.isLottery = true;
                // ���I���ʂ�����ꂽ�t���O��OFF
                GameManager.isResult = false;

                // ���I�J�n
                StartLottery();
            }
        }

    }

    // ���I�J�n
    void StartLottery()
    {
        // 0 �` optionData.option.prizeName �z�񐔖����̐����������_���Ɏ擾������
        GameManager.resultIndex = Random.Range(0, optionData.option.prizeName.Length);

        // ���I���ʂ̃f�o�b�O���O���o��
        Debug.Log(" ���I�ԍ����ʁF" + GameManager.resultIndex);

        // ���I���ʂ�����ꂽ�t���O��ON
        GameManager.isResult = true;
    }

}
