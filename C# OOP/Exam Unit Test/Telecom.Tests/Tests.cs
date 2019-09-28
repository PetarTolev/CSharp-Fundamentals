using System;
using System.Collections.Generic;
using System.Reflection;

namespace Telecom.Tests
{
    using NUnit.Framework;

    public class Tests
    {
        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            this.phone = new Phone("Samsung", "S7");
        }

        [Test]
        public void MakeSet()
        {
            Assert.AreEqual("Samsung", this.phone.Make);
        }

        [Test]
        public void ContactCount()
        {
            this.phone.AddContact("Ivan", "0000");
            this.phone.AddContact("Petar", "1111");
            this.phone.AddContact("Georgi", "2222");

            Assert.AreEqual(this.phone.Count, 3);
        }

        [Test]
        public void AddExistingContact()
        {
            this.phone.AddContact("Ivan", "0000");

            Assert.Throws<InvalidOperationException>(() => this.phone.AddContact("Ivan", "0000"));
        }

        [Test]
        public void Call()
        {
            this.phone.AddContact("Ivan", "0000");

            Assert.AreEqual("Calling Ivan - 0000...", this.phone.Call("Ivan"));
        }

        [Test]
        public void NotExistingPersonCall()
        {
            Assert.Throws<InvalidOperationException>(() => this.phone.Call("Ivan"));
        }
    }
}