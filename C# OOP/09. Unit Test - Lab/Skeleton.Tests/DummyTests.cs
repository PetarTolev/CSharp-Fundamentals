using System;

namespace Skeleton.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private Axe axe;

        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(10, 10);
            this.axe = new Axe(10, 10);
        }

        [Test]
        public void DummyLostHealthIfAttacked()
        {
            this.axe.Attack(this.dummy);

            Assert.AreEqual(0, this.dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionAfterAttack()
        {
            this.dummy.TakeAttack(10);

            Assert.Catch<InvalidOperationException>(() => this.dummy.TakeAttack(1));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            this.dummy.TakeAttack(10);

            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            Assert.Catch<InvalidOperationException>(() => dummy.GiveExperience());
        }

    }
}
