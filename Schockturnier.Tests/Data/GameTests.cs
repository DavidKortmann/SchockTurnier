using FluentAssertions;
using NUnit.Framework;
using Schockturnier.Data;

namespace Schockturnier.Tests.Data
{
    [TestFixture]
    public class GameTests
    {
        protected Game Sut;

        [SetUp]
        protected virtual void Init()
        {
            Sut = new Game();
        }

        public class Test4GroupA4Players : GameTests
        {
            [TestCase(12, 4, 3, 3)]
            [TestCase(15, 4, 3, 4)]
            [TestCase(16, 4, 4, 4)]
            [TestCase(17, 5, 3, 4)]
            [TestCase(19, 5, 3, 4)]
            [TestCase(20, 5, 4, 4)]
            [TestCase(21, 6, 3, 4)]
            [TestCase(23, 6, 3, 4)]
            [TestCase(24, 6, 4, 4)]
            [TestCase(25, 8, 3, 4)]
            [TestCase(31, 8, 3, 4)]
            [TestCase(32, 8, 4, 4)]
            [TestCase(33, 10, 3, 4)]
            [TestCase(39, 10, 3, 4)]
            [TestCase(40, 10, 4, 4)]
            [TestCase(41, 12, 3, 4)]
            public void Test_1_Group(int playerCount, int expectedGroups, int expectedMinPlayersPerGroup, int expectedMaxPlayersPerGroup)
            {
                for (var i = 0; i < playerCount; i++)
                {
                    Sut.Players.Add(new Player($"Player {i + 1}"));
                }
                Sut.StartGame();

                var round = Sut.Rounds[0];

                round.Groups.Should().HaveCount(expectedGroups);
                foreach (var group in round.Groups)
                {
                    group.Players.Count.Should().BeInRange(expectedMinPlayersPerGroup, expectedMaxPlayersPerGroup);
                }
            }

            [TestCase(12, 2, 4)]
            [TestCase(16, 2, 4)]
            [TestCase(17, 2, 5)]
            [TestCase(20, 2, 5)]
            [TestCase(21, 3, 4)]
            [TestCase(24, 3, 4)]
            [TestCase(25, 4, 4)]
            [TestCase(32, 4, 4)]
            [TestCase(33, 5, 4)]
            [TestCase(40, 5, 4)]
            [TestCase(41, 6, 4)]
            public void Test_2_Group(int playerCount, int expectedGroups, int expectedPlayersPerGroup)
            {
                for (var i = 0; i < playerCount; i++)
                {
                    Sut.Players.Add(new Player($"Player {i + 1}"));
                }
                Sut.StartGame();
                Sut.Rounds[0].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();

                var round = Sut.Rounds[1];
                round.Groups.Should().HaveCount(expectedGroups);

                foreach (var group in round.Groups)
                {
                    @group.Players.Count.Should().Be(expectedPlayersPerGroup);
                }
            }

            [TestCase(12, 1, 4, true)]
            [TestCase(16, 1, 4, true)]
            [TestCase(17, 1, 4, true)]
            [TestCase(20, 1, 4, true)]
            [TestCase(21, 1, 6, true)]
            [TestCase(24, 1, 6, true)]
            [TestCase(25, 2, 4, false)]
            [TestCase(32, 2, 4, false)]
            [TestCase(33, 2, 5, false)]
            [TestCase(40, 2, 5, false)]
            [TestCase(41, 3, 4, false)]
            public void Test_3_Group(int playerCount, int expectedGroups, int expectedPlayersPerGroup, bool isFinalRound)
            {
                for (var i = 0; i < playerCount; i++)
                {
                    Sut.Players.Add(new Player($"Player {i + 1}"));
                }
                Sut.StartGame();
                Sut.Rounds[0].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();
                Sut.Rounds[1].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();

                var round = Sut.Rounds[2];
                round.IsFinal.Should().Be(isFinalRound);
                round.Groups.Should().HaveCount(expectedGroups);

                foreach (var group in round.Groups)
                {
                    group.Players.Count.Should().Be(expectedPlayersPerGroup);
                }
            }

            [TestCase(25, 1, 4, true)]
            [TestCase(32, 1, 4, true)]
            [TestCase(33, 1, 4, true)]
            [TestCase(40, 1, 4, true)]
            [TestCase(41, 1, 6, true)]
            public void Test_4_Group(int playerCount, int expectedGroups, int expectedPlayersPerGroup, bool isFinalRound)
            {
                for (var i = 0; i < playerCount; i++)
                {
                    Sut.Players.Add(new Player($"Player {i + 1}"));
                }
                Sut.StartGame();
                Sut.Rounds[0].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();
                Sut.Rounds[1].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();
                Sut.Rounds[2].Groups.ForEach(g => OutPlayers(g, 2));
                Sut.NextRound();

                var round = Sut.Rounds[3];
                round.IsFinal.Should().Be(isFinalRound);
                round.Groups.Should().HaveCount(expectedGroups);

                foreach (var group in round.Groups)
                {
                    group.Players.Count.Should().Be(expectedPlayersPerGroup);
                }
            }
        }

        private void OutPlayers(Group group, int stayingPlayersCount)
        {
            for (var i = 0; i < group.Players.Count - stayingPlayersCount; i++)
            {
                group.Players[i].IsOut = true;
            }
        }
    }
}
