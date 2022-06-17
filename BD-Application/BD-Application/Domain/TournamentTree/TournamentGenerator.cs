using System;
using System.Collections.Generic;

namespace BD_Application.Domain.TournamentTree {
    class TournamentGenerator {
        private Dictionary<Stage, int[]> _stages;
        private int _tournamentID;

        public TournamentGenerator(int id) {
            _stages = new Dictionary<Stage, int[]> {
                { Stage.EighthFinals, new int[]{ 1, 3, 5, 7, 9, 11, 13, 15 } },
                { Stage.QuaterFinals, new int[]{ 2, 6, 10, 14 } },
                { Stage.Semifinals, new int[]{ 4, 12 } },
                { Stage.Final, new int[]{ 8 } }
            };

            _tournamentID = id;
        }
        
        public BinaryTree GenerateTournamentTree(int teamCount, List<Team> teams) {
            var tree = CreateBinaryTree(teamCount - 1);
            CreateMatches(teams);

            return tree;
        }

        private void CreateMatches(List<Team> teams) {
            var matches = new Dictionary<Stage, List<Match>>();
            var gen = new Random();

            var tempMatches = new List<Match>();
            foreach (var id in _stages[Stage.EighthFinals]) {
                //Console.WriteLine($"index: {index}\tCount: {teams.Count}");
                var team1 = teams[gen.Next(0, teams.Count)];
                teams.Remove(team1);

                var team2 = teams[gen.Next(0, teams.Count)];
                teams.Remove(team2);

                var match = CreateMatch(id, team1.Id, team2.Id, Stage.EighthFinals);
                tempMatches.Add(match);
            }

            matches.Add(Stage.EighthFinals, tempMatches);

            foreach (var stage in _stages) {
                if (stage.Key == Stage.EighthFinals) continue;

                tempMatches = new List<Match>();
                foreach(var id in stage.Value) {
                    var match = CreateMatch(id, - 1, -1, stage.Key);
                    tempMatches.Add(match);
                }

                //Console.WriteLine("Name: " + stage.Key);
                matches.Add(stage.Key, tempMatches);
            }

            //Запись матчей в таблицу

        }

        private Match CreateMatch(int id, int team1, int team2, Stage stage) {
            var match = new Match();
            match.Id = id;
            match.DateTimeMatch = RandomDay();
            match.IdFirstTeam = team1;
            match.IdSecondTeam = team2;
            match.MatchStage = stage;
            match.TournamentID = _tournamentID;

            return match;
        }

        private BinaryTree CreateBinaryTree(int matchCount) {
            List<BinaryTreeNode> nodes = new List<BinaryTreeNode>();

            for (int i = 1; i <= matchCount; i++) {
                nodes.Add(new BinaryTreeNode(i));
            }

            BinaryTree tree = FillBinaryTree(nodes);

            return tree;
        }

        private BinaryTree FillBinaryTree(List<BinaryTreeNode> nodes, int size, int side) {
            //int midle = size + ((size / 2) * side);

            BinaryTree tree = new BinaryTree();
            tree.Add(nodes[7]);

            tree.Add(nodes[3]);
            tree.Add(nodes[1]);
            tree.Add(nodes[0]);
            tree.Add(nodes[2]);
            tree.Add(nodes[5]);
            tree.Add(nodes[4]);
            tree.Add(nodes[6]);

            tree.Add(nodes[11]);
            tree.Add(nodes[9]);
            tree.Add(nodes[8]);
            tree.Add(nodes[10]);
            tree.Add(nodes[13]);
            tree.Add(nodes[12]);
            tree.Add(nodes[14]);

            return tree;
        }

        private BinaryTree FillBinaryTree(List<BinaryTreeNode> nodes, BinaryTree tree = null) { 
            if(tree == null)
                tree = new BinaryTree();

            if (nodes.Count == 1) {
                tree.Add(nodes[0]);
                return tree;
            }

            int midle = nodes.Count / 2;

            tree.Add(nodes[midle]);

            List<BinaryTreeNode> leftListSide = nodes.GetRange(0, midle);
            List<BinaryTreeNode> rightListSide = nodes.GetRange(midle, nodes.Count - midle);

            FillBinaryTree(leftListSide, tree);
            FillBinaryTree(rightListSide, tree);

            return tree;
        }

        private DateTime RandomDay() {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
