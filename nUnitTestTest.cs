using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace UnitTestWinForms
{
    [TestFixture]
    public class nUnitTestTest
    {
       
        Form1 form = new Form1();

        [SetUp]
        protected void SetUp()
        {
            form.Show();
        }

        [TearDown]
        protected void TearDown()
        {
            //form.Close();
        }

        [Test]
        public void ButtonsNamedCorrectly()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            ButtonTester button2 = new ButtonTester("btnTwo");
            ButtonTester button3 = new ButtonTester("btnThree");
            Assert.AreEqual(3, button1.Count + button2.Count + button3.Count);
        }

        [Test]
        public void ButtonsTextCorrect()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            ButtonTester button2 = new ButtonTester("btnTwo");
            ButtonTester button3 = new ButtonTester("btnThree");
            Assert.AreEqual("FirstSecondThird", button1.Text + button2.Text + button3.Text);
        }

        [Test]
        public void TextboxesCreatedAndNamedCorrectly()
        {
            ButtonTester textbox1 = new ButtonTester("txtOne");
            ButtonTester textbox2 = new ButtonTester("txtTwo");
            ButtonTester textbox3 = new ButtonTester("txtThree");
            Assert.AreEqual(3, textbox1.Count + textbox2.Count + textbox3.Count);
        }

        [Test]
        public void LabelsCreatedAndNamedCorrectly()
        {
            LabelTester label1 = new LabelTester("lblSum");
            Assert.AreEqual(1, label1.Count);
        }

        [Test]
        public void ButtonOneSetsTextbox()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            button1.Click();
            TextBoxTester textbox1 = new TextBoxTester("txtOne");
            int val = int.Parse(textbox1.Text);
            Assert.IsTrue(val >= 0 && val <= 100);
        }

        [Test]
        public void ButtonTwoSetsTextbox()
        {
            ButtonTester button1 = new ButtonTester("btnTwo");
            button1.Click();
            TextBoxTester textbox1 = new TextBoxTester("txtTwo");
            int val = int.Parse(textbox1.Text);
            Assert.IsTrue(val >= 0 && val <= 3000);
        }

        [Test]
        public void ButtonThreeSetsTextbox()
        {
            ButtonTester button1 = new ButtonTester("btnThree");
            button1.Click();
            TextBoxTester textbox1 = new TextBoxTester("txtThree");
            int val = int.Parse(textbox1.Text);
            Assert.IsTrue(val >= 30000 && val <= 100000);
        }

        [Test]
        public void SumButtonWorks()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            button1.Click();
            ButtonTester button2 = new ButtonTester("btnTwo");
            button2.Click();
            ButtonTester button3 = new ButtonTester("btnThree");
            button3.Click();

            ButtonTester sumButton = new ButtonTester("btnSum");
            sumButton.Click();

            TextBoxTester textbox1 = new TextBoxTester("txtOne");
            int val1 = int.Parse(textbox1.Text);

            TextBoxTester textbox2 = new TextBoxTester("txtTwo");
            int val2 = int.Parse(textbox2.Text);

            TextBoxTester textbox3 = new TextBoxTester("txtThree");
            int val3 = int.Parse(textbox3.Text);

            LabelTester label1 = new LabelTester("lblSum");

            Assert.AreEqual(label1.Text, (val1 + val2 + val3).ToString());
        }

        [Test]
        public void CheckIfStatement()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            button1.Click();
            ButtonTester button2 = new ButtonTester("btnTwo");
            button2.Click();
            ButtonTester button3 = new ButtonTester("btnThree");
            button3.Click();

            ButtonTester checkButton = new ButtonTester("btnCheckOne");
            checkButton.Click();



            TextBoxTester textbox1 = new TextBoxTester("txtOne");
            int val1 = int.Parse(textbox1.Text);

            if (val1 <= 50)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Red);
            else
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Green);
        }



        [Test]
        public void CheckElseIfStatement()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            button1.Click();
            ButtonTester button2 = new ButtonTester("btnTwo");
            button2.Click();
            ButtonTester button3 = new ButtonTester("btnThree");
            button3.Click();

            ButtonTester checkButton = new ButtonTester("btnCheckTwo");
            checkButton.Click();



            TextBoxTester textbox1 = new TextBoxTester("txtTwo");
            int val1 = int.Parse(textbox1.Text);

            if (val1 <= 1000)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Red);
            else if (val1 <= 2000)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Yellow);
            else
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Green);
        }



        [Test]
        public void CheckElseIfStatement2()
        {
            ButtonTester button1 = new ButtonTester("btnOne");
            button1.Click();
            ButtonTester button2 = new ButtonTester("btnTwo");
            button2.Click();
            ButtonTester button3 = new ButtonTester("btnThree");
            button3.Click();

            ButtonTester checkButton = new ButtonTester("btnCheckThree");
            checkButton.Click();



            TextBoxTester textbox3 = new TextBoxTester("txtThree");
            int val1 = int.Parse(textbox3.Text);

            if (val1 <= 30000)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Red);
            else if (val1 <= 50000)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Orange);
            else if (val1 <= 75000)
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Yellow);
            else
                Assert.IsTrue(checkButton.Properties.BackColor == Color.Green);
        }



        [Test]
        public void CheckForLoop()
        {
            ButtonTester button1 = new ButtonTester("btnForLoop");
            button1.Click();
            LabelTester textbox1 = new LabelTester("lblForLoop");
            int val1 = int.Parse(textbox1.Text);
            Assert.IsTrue(val1 == 500500);
        }

        [Test]
        public void CheckWhileLoop()
        {
            ButtonTester button1 = new ButtonTester("btnWhileLoop");
            button1.Click();
            LabelTester textbox1 = new LabelTester("lblWhileLoop");
            int val1 = int.Parse(textbox1.Text);
            Assert.IsTrue(val1 == -201);
        }



    }
}
