using UnityEngine;

public class MazeManager : MonoBehaviour
{
    // 在 Unity 的 Inspector 面板中，把你的三個 level 模型拉進這些格子
    public GameObject maze1;
    public GameObject maze2;
    public GameObject maze3;

    // 當有物體進入「感應區方塊」時，Unity 會自動執行這個區塊
    private void OnTriggerEnter(Collider other)
    {
        // 檢查進入感應區的物體，標籤 (Tag) 是不是 "MainCamera"
        // 這樣可以確保只有玩家的頭盔能觸發切換，而不是其他物體
        if (other.CompareTag("MainCamera"))
        {
            // 邏輯：檢查哪一個迷宮目前是開啟狀態 (activeSelf)
            // 如果 1 號開著，就換成 2 號，依此類推達成無限循環
            if (maze1.activeSelf)
            {
                SwitchTo(2); // 呼叫下方的工具，切換到第 2 個迷宮
            }
            else if (maze2.activeSelf)
            {
                SwitchTo(3); // 呼叫下方的工具，切換到第 3 個迷宮
            }
            else if (maze3.activeSelf)
            {
                SwitchTo(1); // 呼叫下方的工具，換回第 1 個迷宮
            }
        }
    }

    // 這是一個自定義的小工具，專門用來控制三個迷宮的開關
    // targetNumber 代表我們想要顯示哪一個迷宮
    void SwitchTo(int targetNumber)
    {
        // SetActive(true) 會讓物件出現，SetActive(false) 會讓物件消失
        // 這裡是用判斷式來決定：如果號碼相符就 true，不符就 false
        maze1.SetActive(targetNumber == 1);
        maze2.SetActive(targetNumber == 2);
        maze3.SetActive(targetNumber == 3);

        // 這行會在 Unity 編輯器左下角的 Console 視窗印出字，幫你確認程式有在跑
        Debug.Log("玩家踩到感應區！目前切換至迷宮：" + targetNumber);
    }
}