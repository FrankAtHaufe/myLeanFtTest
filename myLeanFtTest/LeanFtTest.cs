﻿using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;

namespace myLeanFtTest
{
    [TestFixture]
    public class LeanFtTest : UnitTestClassBase
    {
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
            // Hello you
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        [Test]
        public void Test()
        {
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
