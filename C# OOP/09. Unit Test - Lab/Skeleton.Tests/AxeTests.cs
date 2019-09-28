using System;

namespace Skeleton.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void AxeAttackingWithBrokenWapon()
        {
            Axe axe = new Axe(10, 1);
            Dummy dummy = new Dummy(10, 10);
            
            axe.Attack(dummy);

            Assert.Catch<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
