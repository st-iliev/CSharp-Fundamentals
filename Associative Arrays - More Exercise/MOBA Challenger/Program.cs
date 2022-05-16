
using System;
using System.Collections.Generic;
using System.Linq;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> mobaPlayers = new Dictionary<string, Dictionary<string, int>>();
            string playerStats = Console.ReadLine();
            while (playerStats != "Season end")
            {
                if (playerStats.Split(" vs ").Length == 2)
                {
                    mobaPlayers.OrderBy(s => s.Value.Values);
                    string playerOnePosition = "";
                    string playerTwoPosition = "";
                    int playerOneSkill = 0;
                    int playerTwoSkill = 0;
                    string firstName = playerStats.Split(" vs ")[0];
                    string secondName = playerStats.Split(" vs ")[1];
                    if (mobaPlayers.ContainsKey(firstName) && mobaPlayers.ContainsKey(secondName))
                    {
                        bool duelIsOver = false;
                        while (duelIsOver != true)
                        {
                            foreach (KeyValuePair<string, Dictionary<string, int>> dragon in mobaPlayers)
                            {
                                if (dragon.Key == firstName)
                                {
                                    if (mobaPlayers[firstName].Count == 0)
                                    {
                                        duelIsOver = true;
                                        mobaPlayers.Remove(firstName);
                                        break;
                                    }
                                    foreach (KeyValuePair<string, int> player in dragon.Value)
                                    {
                                        playerOnePosition = player.Key;
                                        playerOneSkill = player.Value;
                                        if (playerOnePosition == playerTwoPosition)
                                        {
                                            if (playerOneSkill > playerTwoSkill)
                                            {
                                                mobaPlayers.Remove(secondName);
                                                duelIsOver = true;
                                                break;
                                            }
                                            else if (playerOneSkill < playerTwoSkill)
                                            {
                                                mobaPlayers.Remove(firstName);
                                                duelIsOver = true;
                                                break;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                            }
                            foreach (KeyValuePair<string, Dictionary<string, int>> dragon in mobaPlayers)
                            {
                                if (dragon.Key == secondName)
                                {
                                    if (mobaPlayers[secondName].Count == 0)
                                    {
                                        duelIsOver = true;
                                        mobaPlayers.Remove(secondName);
                                        break;
                                    }
                                    foreach (KeyValuePair<string, int> player in dragon.Value)
                                    {
                                        playerTwoPosition = player.Key;
                                        playerTwoSkill = player.Value;
                                        if (playerOnePosition == playerTwoPosition)
                                        {
                                            if (playerOneSkill > playerTwoSkill)
                                            {
                                                mobaPlayers.Remove(secondName);
                                                duelIsOver = true;
                                                break;
                                            }
                                            else if (playerOneSkill < playerTwoSkill)
                                            {
                                                mobaPlayers.Remove(firstName);
                                                duelIsOver = true;
                                                break;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;

                                }
                            }
                            if (duelIsOver)
                            {
                                break;
                            }
                            if (mobaPlayers[firstName].ContainsKey(playerTwoPosition))
                            {
                                if (duelIsOver)
                                {
                                    break;
                                }
                                continue;
                            }
                            else if (mobaPlayers[secondName].ContainsKey(playerOnePosition))
                            {

                                continue;
                            }
                            else
                            {

                                break;
                            }

                        }
                    }
                }

                else
                {
                    string playerName = playerStats.Split(" -> ")[0];
                    string playerPosition = playerStats.Split(" -> ")[1];
                    int playerSkill = int.Parse(playerStats.Split(" -> ")[2]);
                    if (!mobaPlayers.ContainsKey(playerName))
                    {
                        mobaPlayers.Add(playerName, new Dictionary<string, int> { { playerPosition, playerSkill } });
                    }
                    else
                    {
                        if (mobaPlayers[playerName].ContainsKey(playerPosition))
                        {
                            if (mobaPlayers[playerName][playerPosition] < playerSkill)
                            {
                                mobaPlayers[playerName][playerPosition] = playerSkill;
                            }
                        }
                        else
                        {
                            mobaPlayers[playerName].Add(playerPosition, playerSkill);
                        }
                    }
                }
                playerStats = Console.ReadLine();
            }

            Dictionary<string, int> seasonPlayers = new Dictionary<string, int>();
            foreach (KeyValuePair<string, Dictionary<string, int>> dragon in mobaPlayers)
            {
                foreach (KeyValuePair<string, int> skill in dragon.Value)
                {
                    if (seasonPlayers.ContainsKey(dragon.Key))
                    {
                        seasonPlayers[dragon.Key] += skill.Value;
                    }
                    else
                    {
                        seasonPlayers.Add(dragon.Key, skill.Value);
                    }
                }

            }
            foreach (var item in seasonPlayers.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} skill");
                if (mobaPlayers.ContainsKey(item.Key))
                {
                    foreach (KeyValuePair<string, Dictionary<string, int>> dragon in mobaPlayers)
                    {
                        if (dragon.Key == item.Key)
                        {
                            Console.WriteLine($"- {string.Join("\n- ", dragon.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Select(s => $"{ s.Key} <::> {s.Value}"))}");
                        }
                    }
                }
            }
        }
    }
}



