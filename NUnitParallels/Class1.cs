using System;
using NUnit.Framework;

namespace NUnitParallels
{
    [SetUpFixture]
    public class TheFirstOneTimeSetup
    {
        [OneTimeSetUp]
        public void OneTimeSetup1()
        {
            TestContext.Progress.WriteLine("OneTimeSetup1");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown1()
        {
            TestContext.Progress.WriteLine("OneTimeTearDown1");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }


    public class TestClass1
    {
        [Test]
        public void Test2_1()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }
    public class TestClass2
    {
        [Test]
        public void Test2_2()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }
    public class TestClass3
    {
        [Test]
        public void Test2_3()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass34
    {
        [Test]
        public void Test2_4()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass5
    {
        [Test]
        public void Test2_5()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass6
    {
        [Test]
        public void Test2_6()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass7
    {
        [Test]
        public void Test2_7()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass8
    {
        [Test]
        public void Test2_8()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass9
    {
        [Test]
        public void Test2_9()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass10
    {
        [Test]
        public void Test2_10()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }
}

namespace NUnitParallels.Some
{
    [SetUpFixture]
    public class TheSecondOneTimeSetup
    {
        [OneTimeSetUp]
        public void OneTimeSetup2()
        {
            TestContext.Progress.WriteLine("OneTimeSetup2");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown2()
        {
            TestContext.Progress.WriteLine("OneTimeTearDown2");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }


    public class TestClass1
    {
        [Test]
        public void Test1_1()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass2
    {
        [Test]
        public void Test1_2()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }

    public class TestClass3
    {
        [Test]
        public void Test1_3()
        {
            TestContext.Progress.WriteLine(TestContext.CurrentContext.Test.FullName + " started");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    }
}
