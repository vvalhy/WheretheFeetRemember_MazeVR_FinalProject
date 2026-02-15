using UnityEngine;

public class MazeManager : MonoBehaviour
{
    // 在 Inspector 面板中拉入對應的迷宮模型
    public GameObject maze1; // 第一關迷宮
    public GameObject maze2; // 第二關迷宮
    public GameObject maze3; // 第三關迷宮

    // 用來區分這個感應器是哪一組：1=1轉2, 2=2轉3, 3=3轉1
    [Header("設定感應器類型 (1, 2 或 3)")]
    public int triggerType = 1; 

    private void OnTriggerEnter(Collider other)
    {
        // 檢查撞擊者是否帶有 MainCamera 標籤
        if (other.CompareTag("MainCamera"))
        {
            // 根據不同類型的感應器執行特定的切換邏輯
            if (triggerType == 1 && maze1.activeSelf)
            {
                // 如果是第1組感應器，且迷宮1正開啟，則換到迷宮2
                SwitchToMaze2();
                Debug.Log("成功從 Maze 1 切換到 Maze 2");
            }
            else if (triggerType == 2 && maze2.activeSelf)
            {
                // 如果是第2組感應器，且迷宮2正開啟，則換到迷宮3
                SwitchToMaze3();
                Debug.Log("成功從 Maze 2 切換到 Maze 3");
            }
            else if (triggerType == 3 && maze3.activeSelf)
            {
                // 如果是第3組感應器，且迷宮3正開啟，則換到迷宮1
                SwitchToMaze1();
                Debug.Log("成功從 Maze 3 切換到 Maze 1");
            }
        }
    }

    // 切換到迷宮 1 的具體執行代碼
    void SwitchToMaze1()
    {
        maze1.SetActive(true);
        maze2.SetActive(false);
        maze3.SetActive(false);
    }

    // 切換到迷宮 2 的具體執行代碼
    void SwitchToMaze2()
    {
        maze1.SetActive(false);
        maze2.SetActive(true);
        maze3.SetActive(false);
    }

    // 切換到迷宮 3 的具體執行代碼
    void SwitchToMaze3()
    {
        maze1.SetActive(false);
        maze2.SetActive(false);
        maze3.SetActive(true);
    }
}