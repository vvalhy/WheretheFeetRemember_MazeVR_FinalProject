using UnityEngine;

public class UniversalTrigger : MonoBehaviour
{
    [Header("--- 迷宮切換功能 ---")]
    [Tooltip("勾選：觸發時會切換迷宮；取消勾選：不切換迷宮，只做物體開關")]
    public bool enableMazeSwitch = true;

    [Tooltip("所有迷宮物體的列表")]
    public GameObject[] mazes;

    [Tooltip("要切換到的目標迷宮索引 (0~N)")]
    public int targetMazeIndex = 0;


    [Header("--- 物體開關功能 ---")]
    [Tooltip("額外要【開啟】的物體列表")]
    public GameObject[] extraObjectsToEnable;

    [Tooltip("額外要【關閉】的物體列表")]
    public GameObject[] extraObjectsToDisable;


    [Header("--- 觸發器自身設置 ---")]
    [Tooltip("觸發後是否自動關閉【自身】碰撞盒")]
    public bool disableSelfOnTrigger = true;

    private void OnTriggerEnter(Collider other)
    {
        // 檢查撞擊者是否帶有 MainCamera 標籤
        if (other.CompareTag("MainCamera"))
        {
            // 1. 如果勾選了切換迷宮，才執行迷宮切換邏輯
            if (enableMazeSwitch)
            {
                SwitchMaze();
            }

            // 2. 執行物體開關逻辑（不管切不切迷宮，都会執行）
            HandleExtraObjects();

            // 3. 如果勾選了關閉自身，才關閉自己
            if (disableSelfOnTrigger)
            {
                gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 迷宮切換邏輯
    /// </summary>
    void SwitchMaze()
    {
        if (mazes == null || mazes.Length == 0) return;

        if (targetMazeIndex < 0 || targetMazeIndex >= mazes.Length)
        {
            Debug.LogError($"[{gameObject.name}] Target Index {targetMazeIndex} 超出了 mazes 數組範圍！");
            return;
        }

        for (int i = 0; i < mazes.Length; i++)
        {
            if (mazes[i] != null)
            {
                mazes[i].SetActive(i == targetMazeIndex);
            }
        }
    }

    /// <summary>
    /// 物體批量開關邏輯
    /// </summary>
    void HandleExtraObjects()
    {
        foreach (GameObject obj in extraObjectsToEnable)
        {
            if (obj != null) obj.SetActive(true);
        }

        foreach (GameObject obj in extraObjectsToDisable)
        {
            if (obj != null) obj.SetActive(false);
        }
    }
}