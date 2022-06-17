using System;
using System.Collections.Generic;

namespace BD_Application.Domain.TournamentTree {
    /// <summary>
    /// Бинарное дерево
    /// </summary>
    class BinaryTree {
        /// <summary>
        /// Корень бинарного дерева
        /// </summary>
        public BinaryTreeNode RootNode { get; set; }

        /// <summary>
        /// Добавление нового узла в бинарное дерево
        /// </summary>
        /// <param name="node">Новый узел</param>
        /// <param name="currentNode">Текущий узел</param>
        /// <returns>Узел</returns>
        public BinaryTreeNode Add(BinaryTreeNode node, BinaryTreeNode currentNode = null) {
            if (RootNode == null) {
                node.ParentNode = null;
                return RootNode = node;
            }

            currentNode = currentNode ?? RootNode;
            node.ParentNode = currentNode;
            int result;
            return (result = node.Data.CompareTo(currentNode.Data)) == 0
                ? currentNode
                : result < 0
                    ? currentNode.LeftNode == null
                        ? (currentNode.LeftNode = node)
                        : Add(node, currentNode.LeftNode)
                    : currentNode.RightNode == null
                        ? (currentNode.RightNode = node)
                        : Add(node, currentNode.RightNode);
        }

        /// <summary>
        /// Поиск узла по значению
        /// </summary>
        /// <param name="data">Искомое значение</param>
        /// <param name="startWithNode">Узел начала поиска</param>
        /// <returns>Найденный узел</returns>
        public BinaryTreeNode FindNode(int data, BinaryTreeNode startWithNode = null) {
            startWithNode = startWithNode ?? RootNode;
            int result;
            return (result = data.CompareTo(startWithNode.Data)) == 0
                ? startWithNode
                : result < 0
                    ? startWithNode.LeftNode == null
                        ? null
                        : FindNode(data, startWithNode.LeftNode)
                    : startWithNode.RightNode == null
                        ? null
                        : FindNode(data, startWithNode.RightNode);
        }

        /// <summary>
        /// Вывод бинарного дерева
        /// </summary>
        public void PrintTree() {
            PrintTree(RootNode);
        }

        /// <summary>
        /// Вывод бинарного дерева начиная с указанного узла
        /// </summary>
        /// <param name="startNode">Узел с которого начинается печать</param>
        /// <param name="indent">Отступ</param>
        /// <param name="side">Сторона</param>
        private void PrintTree(BinaryTreeNode startNode, string indent = "", Side? side = null) {
            if (startNode != null) {
                var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
                Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Data};");
                indent += new string(' ', 3);
                //рекурсивный вызов для левой и правой веток
                PrintTree(startNode.LeftNode, indent, Side.Left);
                PrintTree(startNode.RightNode, indent, Side.Right);
            }
        }

        public static string Serialize(BinaryTreeNode root) {
            string res = "";
            if (root == null) return res += "#,";
            res += root.Data.ToString();
            res += ",";
            res += Serialize(root.LeftNode);
            res += Serialize(root.RightNode);
            return res;
        }

        public static BinaryTree Deserialize(string data) {
            int size = data.Length;
            if (size == 0) return null;
            var v = new List<string>();
            for (int i = 0; i < size;) {
                if (data[i] != ',' && data[i] != '#') {
                    string s = "";
                    while (i < size && data[i] != ',' && data[i] != '#') {
                        s += data[i];
                        i++;
                    }
                    v.Add(s);
                } else if (data[i] == ',') i++;
                else if (data[i++] == '#') v.Add("#");
            }

            var tree = new BinaryTree();
            tree.Add(helper(v));

            return tree;
        }

        private static BinaryTreeNode helper(List<string> data) {
            BinaryTreeNode res;

            if (data.Count == 0) return null;
            string str = data[0];
            data.Remove(str);
            if (str == "#") {
                return null;
            }
            int tmp = Convert.ToInt32(str);
            res = new BinaryTreeNode(tmp);
            res.LeftNode = helper(data);
            res.RightNode = helper(data);
            return res;
        }
    }
}
