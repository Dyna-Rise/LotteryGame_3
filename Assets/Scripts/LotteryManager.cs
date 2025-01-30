using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LotteryManager : MonoBehaviour
{
    public OptionData optionData;

    // Update is called once per frame
    void Update()
    {
        // ドラムが回転していたら
        if (GameManager.isSpinning == true)
        {
            // 抽選が開始されていない(抽選開始フラフがOFF)なら
            if (GameManager.isLottery == false)
            {
                // 抽選開始フラフをON
                GameManager.isLottery = true;
                // 抽選結果が得られたフラグをOFF
                GameManager.isResult = false;

                // 抽選開始
                StartLottery();
            }
        }

    }

    // 抽選開始
    void StartLottery()
    {
        // 0 ～ optionData.option.prizeName 配列数未満の数字をランダムに取得させる
        GameManager.resultIndex = Random.Range(0, optionData.option.prizeName.Length);

        // 抽選結果のデバッグログを出す
        Debug.Log(" 抽選番号結果：" + GameManager.resultIndex);

        // 抽選結果が得られたフラグをON
        GameManager.isResult = true;
    }

}
