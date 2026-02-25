using UnityEngine;

public class MazeManager : MonoBehaviour
{

    [Header("基礎迷宮設置")]
    public GameObject maze1; // 第一關迷宮
    public GameObject maze2; // 第二關迷宮
    public GameObject maze3; // 第三關迷宮

    // --- 新增：在 Inspector 自由添加的列表 ---
    [Header("額外要【開啟】的物體列表")]
    public GameObject[] extraObjectsToEnable;

    [Header("額外要【關閉】的物體列表")]
    public GameObject[] extraObjectsToDisable;

    
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
                SwitchToMaze2();
                HandleExtraObjects(); // 執行額外的列表開關
                Debug.Log("成功從 Maze 1 切換到 Maze 2，並處理了額外物體");
            }
            else if (triggerType == 2 && maze2.activeSelf)
            {
                SwitchToMaze3();
                HandleExtraObjects(); // 執行額外的列表開關
                Debug.Log("成功從 Maze 2 切換到 Maze 3，並處理了額外物體");
            }
            else if (triggerType == 3 && maze3.activeSelf)
            {
                SwitchToMaze1();
                HandleExtraObjects(); // 執行額外的列表開關
                Debug.Log("成功從 Maze 3 切換到 Maze 1，並處理了額外物體");
            }
        }
    }

    // new
    void HandleExtraObjects()
    {
        // 遍歷列表，批量開啟
        foreach (GameObject obj in extraObjectsToEnable)
        {
            if (obj != null) obj.SetActive(true);
        }

        // 遍歷列表，批量關閉
        foreach (GameObject obj in extraObjectsToDisable)
        {
            if (obj != null) obj.SetActive(false);
        }
    }

    //
    void SwitchToMaze1()
    {
        maze1.SetActive(true);
        maze2.SetActive(false);
        maze3.SetActive(false);
    }

    void SwitchToMaze2()
    {
        maze1.SetActive(false);
        maze2.SetActive(true);
        maze3.SetActive(false);
    }

    void SwitchToMaze3()
    {
        maze1.SetActive(false);
        maze2.SetActive(false);
        maze3.SetActive(true);
    }
}