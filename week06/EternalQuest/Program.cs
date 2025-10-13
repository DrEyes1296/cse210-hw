// Edson Reyes - CSE 210
// Project: W06 Eternal Quest

// --- EXCEEDING REQUIREMENTS NOTE ---
// I have added a new goal type: 'NegativeGoal'. This type of goal is for tracking bad habits the user wants to break.
// When a 'NegativeGoal' event is recorded, points are DEDUCTED from the user's total score, providing a penalty-based incentive to avoid the habit.
// This is integrated into all parts of the program.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}