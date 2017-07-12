using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TournamentData :MonoBehaviour
{

    #region データ変数
    private string tournamentName = "";
    private string myDeckName = "";
    private List<BattleResult> battleResults = new List<BattleResult>();
    #endregion

    public void SetTournamentName(InputField inputField)
    {
        tournamentName = inputField.text;
    }

    public void SetMyDeckName(InputField inputField)
    {
        myDeckName = inputField.text;
    }


}

public class BattleResult
{
    #region データ変数
    private string opponentDeckName = "";
    private int[] sideAmount = new int[2];
    #endregion
}