using System;

public static class LevelEvents 
{
    public static Action<int> OnLevelSlected;
    public static Action OnLevelDataNeeded;
    public static Action<LevelScoresData[]> OnLevelSelectionButtons;
    public static Action<CompleteData> OnLevelWin;
}
