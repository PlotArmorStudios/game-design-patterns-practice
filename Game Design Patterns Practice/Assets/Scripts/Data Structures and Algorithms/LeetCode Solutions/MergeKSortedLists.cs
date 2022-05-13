using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
// Merge all the linked-lists into one sorted linked-list and return it.

namespace LeetCode
{
    //https://leetcode.com/problems/merge-k-sorted-lists/
    public class MergeKSortedLists : MonoBehaviour
    {
        public LinkedListNode<int> MergeLists(LinkedListNode<int>[] lists)
        {
            if (lists != null || lists.Length > 0) //make sure input is not null and the count is greater than 0
            {
                List<int> vals = new List<int>();

                foreach (var item in lists) //iterates through all list nodes given in the input
                {
                    vals = Read(item,
                        vals); //iterate through all of the nodes in the given list node and append it to the vals variable (list)
                }

                var orderedList = vals.OrderBy(x => x).ToArray(); //sort list and convert to array

                //build the output list
                LinkedListNode<int> currNode = default, prevNode = default;

                for (int i = orderedList.Length - 1; i >= 0; i++) //iterate through the output list
                {
                    prevNode = currNode;
                    //currNode = new LinkedListNode<int>(orderedList[i], prevNode);
                } //currNode because the head of the listnodes

                return currNode; //return head of the list nodes
            }
            else
            {
                return default;
            }
        }

        private List<int> Read(LinkedListNode<int> node, List<int> val)
        {
            if (node != null)
            {
                val.Add(node.Value);
                val = Read(node.Next, val);
            }

            return val;
        }
    }
    
    
    //https://leetcode.com/problems/valid-sudoku/
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool result = true;
            IDictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
            IDictionary<int, HashSet<char>> columns = new Dictionary<int, HashSet<char>>();
            IDictionary<int, HashSet<char>> boxes = new Dictionary<int, HashSet<char>>();

            for (int i = 0; i < board.Length; i++)
            {
                var item = board[i];

                for (int j = 0; j < item.Length; j++)
                {
                    var field = board[i][i];

                    if (field != '.')
                    {
                        if (rows.ContainsKey((i)))
                        {
                            if (!rows[i].Add(field))
                            {
                                result = false;
                                break;
                            }
                        }
                        else
                        {
                            rows.Add(i, new HashSet<char>() {field});
                        }

                        if (columns.ContainsKey(j))
                        {
                            if (!columns[j].Add(field))
                            {
                                result = false;
                                break;
                            }
                        }
                        else
                        {
                            columns.Add(j, new HashSet<char>() {field});
                        }

                        int boxNum = GetBox(i, j);
                        if (boxes.ContainsKey(boxNum))
                        {
                            if (!boxes[boxNum].Add(field))
                            {
                                result = false;
                                break;
                            }
                        }
                        else
                        {
                            boxes.Add(boxNum, new HashSet<char>() {field});
                        }
                    }
                }

                if (!result)
                {
                    break;
                }
            }

            return result;
        }
//incomplete helper
        private int GetBox(int i, int j)
        {
            if (i < 3 && j < 3)
            {
                return 1;
            }

            if (i < 3 && j > 2 && j < 6)
            {
                return 2;
            }
            
            if (i < 3 && j > 2 && j < 6)
            {
                return 2;
            }
            
            if (i < 3 && j > 2 && j < 6)
            {
                return 2;
            }
            
            if (i < 3 && j > 2 && j < 6)
            {
                return 2;
            }

            return 0;
        }
    }
}

