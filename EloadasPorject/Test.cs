using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace EloadasPorject
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void UjEloadas()
        {
            Eloadas e = new Eloadas(5, 5);
            Assert.AreEqual(new bool[5, 5], e.Foglalasok);
        }
        [TestCase]
        public void UjEloadasRossz()
        {
            Assert.Throws<ArgumentException>(() => {
                Eloadas e = new Eloadas(-1, -1);
            });
        }

        [TestCase]
        public void UjLefoglal()
        {
            Eloadas e = new Eloadas(1, 1);
            e.Lefoglal();
            bool[,] expected = new bool[1, 1];
            expected[0, 0] = true;
            Assert.AreEqual(expected, e.Foglalasok);
        }
        [TestCase]
        public void RosszLefoglal()
        {
            Eloadas e = new Eloadas(1, 1);
            e.Lefoglal();
            e.Lefoglal();
            bool[,] expected = new bool[1, 1];
            expected[0, 0] = true;
            Assert.AreEqual(expected, e.Foglalasok);
        }
        [TestCase]
        public void UjSzabadHelyek()
        {
            Eloadas e = new Eloadas(2, 2);
            Assert.AreEqual(4, e.SzabadHelyek);
        }
        [TestCase]
        public void UjSzabadHelyekLefoglal()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            Assert.AreEqual(3, e.SzabadHelyek);
        }
        [TestCase]
        public void RosszSzabadHelyek()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(0, e.SzabadHelyek);
        }
        [TestCase]
        public void TeliVan()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(true, e.Teli());
        }
        [TestCase]
        public void NincsTeli()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(false, e.Teli());
        }
        [TestCase]
        public void NemFoglalt()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(false, e.Foglalt(2, 2));
        }
        [TestCase]
        public void Foglalt()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(true, e.Foglalt(1, 1));
        }
        [TestCase]
        public void RosszFoglalt()
        {
            Eloadas e = new Eloadas(2, 2);
            e.Lefoglal();
            e.Lefoglal();
            e.Lefoglal();
            Assert.Throws<ArgumentException>(() => {
                e.Foglalt(-1, -1);
            });
        }
    }
}
