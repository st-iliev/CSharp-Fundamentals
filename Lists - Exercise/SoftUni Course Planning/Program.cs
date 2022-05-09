using System;
using System.Collections.Generic;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            List<string> commands = Console.ReadLine().Split(":").ToList();
            while (commands[0] != "course start")
            {
                int index = 0;
                string exercise = "";
                if (commands[0] == "Add")
                {
                    if (!schedule.Contains(commands[1]))
                    {
                        schedule.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    if (!schedule.Contains(commands[1]))
                    {
                        index = int.Parse(commands[2]);
                        schedule.Insert(index, commands[1]);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (schedule.Contains(commands[1]))
                    {
                        exercise = commands[1];
                        exercise += "-";
                        exercise += "Exercise";
                        if (schedule.Contains(commands[1]))
                        {
                            schedule.Remove(exercise);
                        }
                        schedule.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    int index1 = 0;
                    int index2 = 0;
                    if (schedule.Contains(commands[1]) && (schedule.Contains(commands[2])))
                    {

                        index1 = schedule.FindIndex(a => a.Contains(commands[1]));
                        index2 = schedule.FindIndex(a => a.Contains(commands[2]));
                        string currentLesson = schedule[index1];
                        schedule[index1] = schedule[index2];
                        schedule[index2] = currentLesson;
                        string exercise1 = commands[1];
                        exercise1 += "-";
                        exercise1 += "Exercise";
                        string exercise2 = commands[2];
                        exercise2 += "-";
                        exercise2 += "Exercise";
                        if (schedule.Contains(exercise1))
                        {
                            int indexExercise1 = schedule.FindIndex(a => a.Contains(exercise1));
                            string currentExercise = schedule[indexExercise1];
                            schedule.RemoveAt(indexExercise1);
                            schedule.Insert(index2 + 1, currentExercise);
                        }
                        else if (schedule.Contains(exercise2))
                        {
                            int indexExercise2 = schedule.FindIndex(a => a.Contains(exercise2));
                            string currentExercise = schedule[indexExercise2];
                            schedule.RemoveAt(indexExercise2);
                            schedule.Insert(index1 + 1, currentExercise);
                        }
                    }
                }
                else if (commands[0] == "Exercise")
                {
                    exercise = commands[1];
                    exercise += "-";
                    exercise += "Exercise";
                    if (!schedule.Contains(exercise))
                    {
                        if (schedule.Contains(commands[1]))
                        {
                            index = schedule.FindIndex(a => a.Contains(commands[1]));
                            schedule.Insert(index + 1, exercise);
                        }
                        else
                        {
                            schedule.Add(commands[1]);
                            schedule.Add(exercise);
                        }
                    }

                }
                commands = Console.ReadLine().Split(":").ToList();
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}