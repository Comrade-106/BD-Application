namespace BD_Application.Domain.TournamentTree {
    class BinaryTreeNode {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="data">Данные</param>
        public BinaryTreeNode(int data) {
            Data = data;
        }

        /// <summary>
        /// Данные которые хранятся в узле
        /// </summary>
        public int MatchID { get; set; }

        public int Data { get; set; }

        /// <summary>
        /// Левая ветка
        /// </summary>
        public BinaryTreeNode LeftNode { get; set; }

        /// <summary>
        /// Правая ветка
        /// </summary>
        public BinaryTreeNode RightNode { get; set; }

        /// <summary>
        /// Родитель
        /// </summary>
        public BinaryTreeNode ParentNode { get; set; }

        /// <summary>
        /// Расположение узла относительно его родителя
        /// </summary>
        public Side? NodeSide =>
            ParentNode == null
            ? (Side?)null
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        /// <summary>
        /// Преобразование экземпляра класса в строку
        /// </summary>
        /// <returns>Данные узла дерева</returns>
        public override string ToString() => Data.ToString();
    }
}
